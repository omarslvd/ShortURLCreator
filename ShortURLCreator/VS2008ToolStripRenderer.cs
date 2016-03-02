using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ShortURLCreator
{
    public class VS2008ToolStripRenderer : ToolStripProfessionalRenderer
    {

        // Render custom background gradient
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);

            using (var b = new LinearGradientBrush(e.AffectedBounds,
                VS2008RenderColor.clrVerBG_White, VS2008RenderColor.clrVerBG_GrayBlue, LinearGradientMode.Vertical))
            {
                using (var shadow = new SolidBrush(VS2008RenderColor.clrVerBG_Shadow))
                {
                    var rect = new Rectangle(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1);
                    e.Graphics.FillRectangle(b, e.AffectedBounds);
                    e.Graphics.FillRectangle(shadow, rect);
                }
            }
        }

        // Render button selected and pressed state
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderButtonBackground(e);
            var rectBorder = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
            var rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);

            if (e.Item.Selected == true || (e.Item as ToolStripButton).Checked)
            {
                using (var b = new LinearGradientBrush(rect, VS2008RenderColor.clrToolstripBtnGrad_White,
                    VS2008RenderColor.clrToolstripBtnGrad_Blue, LinearGradientMode.Vertical))
                {
                    using (var b2 = new SolidBrush(VS2008RenderColor.clrToolstripBtn_Border))
                    {
                        e.Graphics.FillRectangle(b2, rectBorder);
                        e.Graphics.FillRectangle(b, rect);
                    }
                }
            }
            if (e.Item.Pressed)
            {
                using (var b = new LinearGradientBrush(rect, VS2008RenderColor.clrToolstripBtnGrad_White_Pressed,
                    VS2008RenderColor.clrToolstripBtnGrad_Blue_Pressed, LinearGradientMode.Vertical))
                {
                    using (var b2 = new SolidBrush(VS2008RenderColor.clrToolstripBtn_Border))
                    {
                        e.Graphics.FillRectangle(b2, rectBorder);
                        e.Graphics.FillRectangle(b, rect);
                    }
                }
            }
        }
    }
}
