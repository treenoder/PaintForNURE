using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PaintForNURE.App.Tool;

namespace PaintForNURE
{
    public partial class Form1 : Form
    {
        private Bitmap _canvas;
        private Graphics _graphics;
        private bool _isDrawing;
        private ToolParams _params;
        private ITool _activeTool;

        public Form1()
        {
            InitializeComponent();
            _canvas = new Bitmap(pbCanvas.Width, pbCanvas.Height);
            _graphics = Graphics.FromImage(_canvas);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _isDrawing = false;
            _params = new ToolParams(Point.Empty, Point.Empty, Point.Empty, Color.Black, 2);
            _activeTool = new App.Tool.Pen(_graphics, _params);
            btnColor.BackColor = _params.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isDrawing) return;
            pbCanvas.Focus();
            _isDrawing = true;
            _params.StartPoint = e.Location;
            _params.LastPoint = e.Location;
            _params.CurrentPoint = e.Location;
            _activeTool.Draw();
            pbCanvas.Invalidate();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _params.CurrentPoint = e.Location;
                _activeTool.Draw();
                _params.LastPoint = e.Location;
                pbCanvas.Invalidate();
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void canvas_Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_canvas, 0, 0);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _params.Color = colorDialog.Color;
                _activeTool.Update();
            }

            btnColor.BackColor = _params.Color;
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            _params.Size = (int)numSize.Value;
            _activeTool.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pbCanvas.Invalidate();
        }
    }
}