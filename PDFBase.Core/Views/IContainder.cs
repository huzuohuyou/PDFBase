using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFBase.Core.Views
{
    public interface IContainder
    {
        void SwitchView(IView view);
    }
}
