using ImageProcessingInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    public partial class Form1 : Form
    {
        int? x = null;
        int? y = null;
        Graphics graphics;
        Color selectedColor;
        Image openedImage;
        SolidBrush solid;
        Pen pen;
        bool isPainting = false;
        bool drawRectangle = false;
        bool drawEllipse = false;
        private Stack<Bitmap> undoList = new Stack<Bitmap>();
        private Stack<Bitmap> redoList = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            selectedColor = Color.Black;
            statusLabel.Text = "";
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            
            DirectoryInfo di = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\plugins\");
            FileInfo[] plugins = di.GetFiles("*.dll");
            ToolStripMenuItem pluginsMenu = new ToolStripMenuItem("Wtyczki");
            if (plugins.Length == 0)
            {
                pluginsMenu.DropDownItems.Add(new ToolStripMenuItem("Brak wtyczek"));
            }
            foreach(FileInfo plugin in plugins)
            {
                string pluginPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\plugins\" + plugin.Name;
                var assembly = Assembly.LoadFrom(pluginPath);
                foreach(Type type in assembly.GetTypes())
                {
                    if(type.IsClass)
                    {
                        if(type.IsPublic)
                        {
                            if(typeof(ImageProcessing).IsAssignableFrom(type))
                            {
                                var o = Activator.CreateInstance(type);
                                var p = (ImageProcessing)o;
                                ToolStripMenuItem plug = new ToolStripMenuItem(p.getName());
                                plug.Click += (s, e) => {
                                    undoList.Push((Bitmap)pictureBox1.Image);
                                    p.changeImage((Bitmap)pictureBox1.Image);
                                    graphics = Graphics.FromImage(pictureBox1.Image);
                                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                    redoList.Clear();
                                    pictureBox1.Refresh();
                                };
                                pluginsMenu.DropDownItems.Add(plug);
                            }
                        }
                    }
                }
            }
            menuStrip1.Items.Add(pluginsMenu);
        }

        private void listShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentShape = listShape.SelectedItem.ToString();

            switch (listShape.SelectedIndex)
            {
                case 0:
                    drawEllipse = true;
                    drawRectangle = false;
                    break;
                case 1:
                    drawEllipse = false;
                    drawRectangle = true;
                    break;
                case 2:
                    drawEllipse = false;
                    drawRectangle = false;
                    break;
                default:
                    drawEllipse = false;
                    drawRectangle = false;
                    break;
            }
        }

        private void listColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listColor.SelectedIndex)
            {
                case 0:
                    selectedColor = Color.Black;
                    break;
                case 1:
                    selectedColor = Color.Red;
                    break;
                default:
                    selectedColor = Color.Black;
                    break;
            }
        }

        private void undoItem_Click(object sender, EventArgs e)
        {
            if(undoList.Count != 0)
            {
                statusLabel.Text = "Undo last action";
                Bitmap undoImage = undoList.Pop();
                redoList.Push((Bitmap)pictureBox1.Image);
                pictureBox1.Image = undoImage;
                graphics = Graphics.FromImage(undoImage);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pictureBox1.Refresh();
            }
        }

        private void reduItem_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Redo last action";
            if(redoList.Count != 0)
            {
                Bitmap redoImage = redoList.Pop();
                undoList.Push((Bitmap)pictureBox1.Image);
                pictureBox1.Image = redoImage;
                graphics = Graphics.FromImage(pictureBox1.Image);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pictureBox1.Refresh();
            }

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting)
            {
                pen = new Pen(selectedColor, 3);
                graphics.DrawLine(pen, new Point(x ?? e.X, y ?? e.Y), new Point(e.X, e.Y));

                x = e.X;
                y = e.Y;

                pictureBox1.Refresh();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
            x = null;
            y = null;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            Bitmap madeImage = new Bitmap(pictureBox1.Image);
            undoList.Push(madeImage);
            redoList.Clear();
            isPainting = true;
            solid = new SolidBrush(selectedColor);
            if (drawRectangle)
            {
                graphics.FillRectangle(solid, e.X, e.Y, 10, 10);
                pictureBox1.Refresh();
                isPainting = false;
            }
            else if (drawEllipse)
            {
                graphics.FillEllipse(solid, e.X, e.Y, 10, 10);
                pictureBox1.Refresh();
                isPainting = false;

            }

        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            undoList.Push((Bitmap)pictureBox1.Image);
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmaps|*.bmp|Images|*.jpg|Png|*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                openedImage = Bitmap.FromFile(open.FileName);
                graphics.DrawImage(openedImage, new Point(0,0));
                graphics = Graphics.FromImage(pictureBox1.Image);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pictureBox1.Refresh();
                
            }
        }

    }
}
