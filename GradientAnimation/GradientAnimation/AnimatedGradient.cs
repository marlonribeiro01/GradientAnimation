using System.Threading.Tasks;
using Xamarin.Forms;
using XFGloss;

namespace GradientAnimation
{
    public class AnimatedGradient : Gradient
    {
        public AnimatedGradient()
        {
            Rotation = 45;
            Animate();
            //AnimateRotation();
        }

        public async Task AnimateRotation()
        {
            while (true)
            {
                for (int r = 0; r < 360; r++)
                {
                    Rotation = r;
                    await Task.Delay(50);
                }
            }
        }

        public async Task Animate()
        {
            while (true)
            {
                for (int h = 1; h <= 1000; h++)
                {
                    Steps.Clear();
                    StartColor = Color.FromHsla((double)h / 1000, 0.5, 0.6);
                    EndColor = Color.FromHsla((double)h / (1000 - h), 0.5, 0.6);
                    await Task.Delay(10);
                }
            }
        }

    }
}
