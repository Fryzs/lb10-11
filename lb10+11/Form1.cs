using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lb10_11
{

    public partial class Form1 : Form
    {
        private bool isDrawingLine = false;
        private bool isDrawing = false;
        private bool isErasing = false;
        private bool isElips = false;
        private bool isCopy = false;
        private bool isPaste = false;
        private Point startPoint;
        private Point endPoint;
        private Bitmap tmpBitmap;
        private Rectangle copyRect;
        private Color primaryColor = Color.Black;
        private Color secondaryColor = Color.White;
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private bool isPipetteMode = false;
        public Pen pen;
        private Rectangle selectionRect;
        private Bitmap copiedImage = null;

        int x0, y0;


        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(primaryColor, (float)numericPenSize.Value);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            undoStack.Push((Bitmap)tmpBitmap.Clone());
            startPoint = e.Location;
            if (pencilButton.Checked && e.Button == MouseButtons.Left)
            {
                isDrawingLine = true;
            }

            if (BtEraser.Checked && e.Button == MouseButtons.Left)
            {
                isErasing = true;
            }

            if (BtFill.Checked)
            {
                FillArea(e.Location, secondaryColor);
                textBox1.AppendText("Brush " + startPoint.X.ToString() + " " + startPoint.Y.ToString() + "\r\n");
            }
            if (PipetteMode.Checked)
            {
                primaryColor = tmpBitmap.GetPixel(e.X, e.Y);
                colorPrimary.BackColor = tmpBitmap.GetPixel(e.X, e.Y);
                textBox1.AppendText("Pipette " + startPoint.X.ToString() + " " + startPoint.Y.ToString() + "\r\n");
            }
            if (Drawing.Checked)
            {
                isDrawing = true;
            }
            if (Elips.Checked)
            {
                isElips = true;
            }
            if (Select.Checked)
            {
                isCopy = true;
            }
            if (Paste.Checked)
            {
                if (copiedImage != null)
                {
                    Graphics g = Graphics.FromImage(tmpBitmap);
                    g.DrawImage(copiedImage, e.Location);
                    pictureBox1.Invalidate();
                }

            }
            if (TextEdit.Checked)
            {
                textBox2.Visible = true;
                textBox2.Location = e.Location;
                textBox2.Focus();
                label1.Visible = true;
                button2.Visible = true;
                textBox2.BringToFront();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = tmpBitmap;
            textBox1.Multiline = true;
            textBox2.BringToFront();

        }
        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(tmpBitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = tmpBitmap;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawingLine && e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(tmpBitmap))
                {
                    g.DrawLine(pen, startPoint, e.Location);
                    textBox1.AppendText("DrawingLine " + startPoint.X.ToString() + " " + startPoint.Y.ToString() + " " + e.Location.X.ToString() + " " + e.Location.Y.ToString() + "\r\n");

                }
                startPoint = e.Location;
                pictureBox1.Invalidate();
            }
            if (isErasing && e.Button == MouseButtons.Left)
            {
                Color tmp = pen.Color;
                pen.Color = Color.White;
                using (Graphics g = Graphics.FromImage(tmpBitmap))
                {
                    g.DrawLine(pen, startPoint, e.Location);
                    textBox1.AppendText("Lastick " + startPoint.X.ToString() + " " + startPoint.Y.ToString() + " " + e.Location.X.ToString() + " " + e.Location.Y.ToString() + "\r\n");
                }
                startPoint = e.Location;
                pictureBox1.Invalidate();
                pen.Color = tmp;
            }
            if (isCopy && e.Button == MouseButtons.Left)
            {
                selectionRect = new Rectangle(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y), Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                pictureBox1.Invalidate();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawingLine = false;
            isErasing = false;

            if (isDrawing)
            {
                endPoint = e.Location;
                isDrawing = false;


                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(pen, startPoint, endPoint);
                    textBox1.AppendText("Line " + startPoint.X.ToString() + " " + startPoint.Y.ToString() + " " + e.Location.X.ToString() + " " + e.Location.Y.ToString() + "\r\n");
                }

                pictureBox1.Invalidate();
            }

            if (isElips)
            {
                endPoint = e.Location;
                isElips = false;


                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                    textBox1.AppendText("Ellipse " + startPoint.X.ToString() + " " + startPoint.Y.ToString() + " " + e.Location.X.ToString() + " " + e.Location.Y.ToString() + "\r\n");

                }

                pictureBox1.Invalidate();
            }
            if (isCopy)
            {
                isCopy = false;
                if (selectionRect.Width > 0 && selectionRect.Height > 0)
                {
                    copiedImage = new Bitmap(selectionRect.Width, selectionRect.Height);
                    using (Graphics g = Graphics.FromImage(copiedImage))
                    {
                        g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, copiedImage.Width, copiedImage.Height),
                                    selectionRect, GraphicsUnit.Pixel);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearCanvas();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    primaryColor = colorDialog.Color;
                    pen.Color = colorDialog.Color;
                    colorPrimary.BackColor = primaryColor;
                    string colorString = pen.Color.ToString();
                    colorString = colorString.Replace("Color [", "").Replace("]", "");
                    textBox1.AppendText("colorPrimary " + colorString + "\r\n");
                }
            }
        }

        private void colorSecondary_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    secondaryColor = colorDialog.Color;
                    colorSecondary.BackColor = secondaryColor;
                    string colorString = secondaryColor.ToString();
                    colorString = colorString.Replace("Color [", "").Replace("]", "");
                    textBox1.AppendText("colorPrimary " + colorString + "\r\n");
                }
            }

        }
        private void FillArea(Point point, Color color)
        {
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(point);

            Color targetColor = tmpBitmap.GetPixel(point.X, point.Y);

            if (targetColor.ToArgb() == color.ToArgb())
                return;

            while (pixels.Count > 0)
            {
                Point current = pixels.Pop();

                if (current.X < 0 || current.Y < 0 || current.X >= tmpBitmap.Width || current.Y >= tmpBitmap.Height)
                    continue;

                if (tmpBitmap.GetPixel(current.X, current.Y) == targetColor)
                {
                    tmpBitmap.SetPixel(current.X, current.Y, color);

                    pixels.Push(new Point(current.X + 1, current.Y));
                    pixels.Push(new Point(current.X - 1, current.Y));
                    pixels.Push(new Point(current.X, current.Y + 1));
                    pixels.Push(new Point(current.X, current.Y - 1));
                }
            }

            pictureBox1.Invalidate();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmpBitmap = undoStack.Pop();
            pictureBox1.Image = tmpBitmap;
            pictureBox1.Invalidate();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (domainUpDown1.SelectedIndex)
            {
                case 0:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                case 1:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 2:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 3:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case 4:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
                case 5:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                    break;
            }

        }

        private void numericPenSize_Scroll(object sender, ScrollEventArgs e)
        {
            pen.Width = numericPenSize.Value;
            textBox1.AppendText("Size " + numericPenSize.Value.ToString() + "\r\n");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pencilButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isCopy)
            {

                e.Graphics.DrawRectangle(Pens.Red, selectionRect);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.BringToFront();

            if (e.KeyCode == Keys.Enter)
            {

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString(textBox2.Text, label1.Font, Brushes.Black, startPoint);
                }
                textBox2.Visible = false;
                textBox2.Text = "";
                label1.Visible = false;
                button2.Visible = false;

            }

        }

        private void seveMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(textBox1.Text);
                }
            }
        }

        private void loadMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                string fileContent = File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = fileContent;

                int x1, x2, y1, y2;

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    string command = parts[0];

                    switch (command)
                    {

                        case "DrawingLine":

                            x1 = int.Parse(parts[1]);
                            y1 = int.Parse(parts[2]);
                            x2 = int.Parse(parts[3]);
                            y2 = int.Parse(parts[4]);
                            startPoint = new Point(x1, y1);
                            endPoint = new Point(x2, y2);

                            using (Graphics g = Graphics.FromImage(tmpBitmap))
                            {
                                g.DrawLine(pen, startPoint, endPoint);
                            }

                            break;
                        case "Line":

                            x1 = int.Parse(parts[1]);
                            y1 = int.Parse(parts[2]);
                            x2 = int.Parse(parts[3]);
                            y2 = int.Parse(parts[4]);
                            startPoint = new Point(x1, y1);
                            endPoint = new Point(x2, y2);

                            using (Graphics g = Graphics.FromImage(tmpBitmap))
                            {
                                g.DrawLine(pen, startPoint, endPoint);
                            }

                            break;

                        case "Ellipse":
                            if (parts.Length >= 5)
                            {
                                x1 = int.Parse(parts[1]);
                                y1 = int.Parse(parts[2]);
                                x2 = int.Parse(parts[3]);
                                y2 = int.Parse(parts[4]);
                                using (Graphics g = Graphics.FromImage(tmpBitmap))
                                {
                                    g.DrawEllipse(pen, x1, y1, x2 - x1, y2 - y1);
                                }
                            }
                            break;

                        case "Lastick":
                            if (parts.Length >= 3)
                            {
                                x1 = int.Parse(parts[1]);
                                y1 = int.Parse(parts[2]);
                                using (Graphics g = Graphics.FromImage(tmpBitmap))
                                {
                                    Color tmp = pen.Color;
                                    pen.Color = Color.White;
                                    g.DrawLine(pen, startPoint, new Point(x1, y1));
                                    pen.Color = tmp;
                                }
                                startPoint = new Point(x1, y1);
                            }
                            break;

                        case "colorPrimary":

                            string colorHex = parts[1];
                            pen.Color = ColorTranslator.FromHtml(colorHex); ;
                            colorPrimary.BackColor = pen.Color;

                            break;

                        case "Size":

                            pen.Width = int.Parse(parts[1]);

                            break;

                        case "Brush":
                            if (parts.Length >= 3)
                            {
                                x1 = int.Parse(parts[1]);
                                y1 = int.Parse(parts[2]);
                                startPoint = new Point(x1, y1);
                                using (Graphics g = Graphics.FromImage(tmpBitmap))
                                {
                                    FillArea(startPoint, secondaryColor);
                                }
                            }
                            break;
                    }
                }

                pictureBox1.Image = tmpBitmap;

            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Define variables for the drawing
            int x = 10, y = 10, h = 370, w = 330;
            float dx = 10, dy = 10;

            PointF[] points = new PointF[3]
            {
            new PointF(x + 8 * dx, y + 15 * dy),
            new PointF(x + 17 * dx, y + 5 * dy),
            new PointF(x + 25 * dx, y + 15 * dy)
            };

            Brush brush = new SolidBrush(Color.Brown);
            Brush brush1 = new SolidBrush(Color.Black);
            Pen whitePen = new Pen(Color.Brown);
            using (Graphics g = Graphics.FromImage(tmpBitmap))
            {
                g.FillRectangle(brush, x + 8 * dx, y + 15 * dy, x + (25 * dx - 9 * dx), y + (37 * dy -  16 * dy));
                g.DrawRectangle(pen, x + 8 * dx, y + 15 * dy, x + (25 * dx - 9 * dx), y + (37 * dy - 16 * dy));
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);

                g.FillRectangle(brush, x + 1 * dx, y + 8 * dy, 32 * dx - 1 * dx, 12 * dy - 8 * dy);
                g.DrawRectangle(pen, x + 1 * dx, y + 8 * dy, 32 * dx - 1 * dx, 12 * dy - 8 * dy);

                g.FillRectangle(brush, x + 15 * dx, y, 19 * dx - 15 * dx, 24 * dy);
                g.DrawRectangle(pen, x + 15 * dx, y, 19 * dx - 15 * dx, 24 * dy);

                g.FillEllipse(brush, x + 14 * dx, y + 7 * dy, 20 * dx - 14 * dx, 12 * dy - 7 * dy);
                g.DrawEllipse(pen, x + 14 * dx, y + 7 * dy, 20 * dx - 14 * dx, 12 * dy - 7 * dy);

                g.FillRectangle(brush1, x + 14 * dx, y + 30 * dy, 20 * dx - 14 * dx, 37 * dy - 30 * dy);
                g.DrawRectangle(pen, x + 14 * dx, y + 30 * dy, 20 * dx - 14 * dx, 37 * dy - 30 * dy);
                pictureBox1.Invalidate();
            }


        }
    }
}
