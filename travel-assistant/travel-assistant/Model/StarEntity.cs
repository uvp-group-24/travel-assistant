using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;

namespace travel_assistant.Model
{
    public class StarEntity
    {
        const double LEFT = 350;

        const double TOP = 800;

        const double GONE = 480;

        private double _affinity;

        private Guid _identifier = Guid.NewGuid();

        private static Random _random = new Random();

        private Canvas _surface;

        public Canvas Surface
        {
            get { return _surface; }
        }

        private double x, y, velocity;
        
        private Image MyStar;

        public Guid Identifier
        {
            get { return _identifier; }
        }

        public StarEntity(Action<Image> insert)
            : this(insert, true)
        {
        }

        public static Image CreateStar()
        {
            Image ret = new Image();
            ret.Source = new BitmapImage(new Uri("ms-appx://travel-assistant/Assets/Me/LittleStar.jpg"));
            ret.Height = 50;
            ret.Width = 50;

            RotateTransform rotate = new RotateTransform();
            rotate.CenterX = 0.5;
            rotate.CenterY = 0.5;
            rotate.Angle = _random.NextDouble() * 360.0;
            ret.SetValue(Image.RenderTransformProperty, rotate);
            return ret;
        }

        public StarEntity(Action<Image> insert, bool fromTop)
        {

            MyStar = CreateStar();

            _affinity = _random.NextDouble();

            velocity = _random.NextDouble() * 2;
            //x = _random.NextDouble() * LEFT;
            //y = fromTop ? 0 : _random.NextDouble() * TOP;

            x = 0.5 * LEFT;
            y = 175;

            MyStar.SetValue(Canvas.LeftProperty, x);
            MyStar.SetValue(Canvas.TopProperty, y);

            insert(MyStar);
            //insert(_starflake);

            _surface = MyStar.Parent as Canvas;
            //_surface = _starflake.Parent as Canvas;

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        void CompositionTarget_Rendering(object sender, object e)
        {
            _Frame();
        }

        private void _Frame()
        {
            //y = y + velocity + 3.0 * _random.NextDouble() - 1.0;

            if (y > GONE || y < 0 || x < 0 || x > LEFT)
            {
                CompositionTarget.Rendering -= CompositionTarget_Rendering;

                _surface.Children.Remove(MyStar);
                //_surface.Children.Remove(_starflake);

                EventHandler handler = StarflakeDied;
                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }
            }
            else
            {
                if (x == 0.5 * LEFT && y == 175)
                {
                    double move_x = _random.NextDouble();
                    double move_y = _random.NextDouble();
                    if (_random.NextDouble() < 0.5) x += move_x;
                    else x -= move_x;
                    if (_random.NextDouble() < 0.5) y += move_y;
                    else y -= move_y;
                }
                else
                {
                    if (_affinity < 0.3) _affinity += 0.5;
                    double move = 10.0 * _affinity;
                    double offset_x = System.Math.Abs(x - 0.5 * LEFT);
                    double offset_y = System.Math.Abs(y - 175);
                    double sum = System.Math.Sqrt(offset_x * offset_x + offset_y * offset_y);
                    if (x > 0.5 * LEFT) x += move * offset_x / sum;
                    else x -= move * offset_x / sum;
                    if (y > 175) y += move * offset_y / sum;
                    else y -= move * offset_y / sum;
                }
                


                MyStar.SetValue(Canvas.LeftProperty, x);
                MyStar.SetValue(Canvas.TopProperty, y);
            }

            RotateTransform rotate = (RotateTransform)MyStar.GetValue(Image.RenderTransformProperty);
            rotate.Angle += _random.NextDouble() * 4.0 * _affinity;
        }

        public event EventHandler StarflakeDied;

        #region Overrides

        public override int GetHashCode()
        {
            return Identifier.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is StarEntity && ((StarEntity)obj).Identifier.Equals(Identifier);
        }
        #endregion
    }
}
