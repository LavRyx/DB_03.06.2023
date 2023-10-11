using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LAVR_KP.GUI.GUI_Classes
{
    public partial class AnimationComponent : Component
    {
        #region [ Поля класса ]
        private Form _sourceForm;
        private FormAnimateEffects _closeEfffect = FormAnimateEffects.ПОЯВЛЕНИЕ_ЗАТУХАНИЕ;
        private FormAnimateEffects _activateEfffect = FormAnimateEffects.РАСКРЫТИЕ_СКРЫТИЕ;

        #endregion
        #region [ Свойства класса ]
        public FormAnimateEffects CloseEffect
        {
            get => _closeEfffect;
            set => _closeEfffect = value;
        }
        public FormAnimateEffects ActivateEffect
        {
            get => _activateEfffect;
            set => _activateEfffect = value;
        }
        public Control SourceForm
        {
            get => _sourceForm;
            set
            {
                if (value is Form)
                    _sourceForm = (value as Form);
            }
        }
        #endregion
        public AnimationComponent()
        {
            InitializeComponent();
        }

        public AnimationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #region [ Методы ]
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, uint flags);

        public void ShowForm(int millisecond)
        {
            AnimateWindow(_sourceForm.Handle, millisecond, (uint)_activateEfffect | 0x00020000);
            _sourceForm.Show();
        }
        public void CloseForm(int millisecond)
        {
            AnimateWindow(_sourceForm.Handle, millisecond, (uint)_activateEfffect | 0x00010000);
            _sourceForm.Close();
            Application.Exit();
        }
        #endregion

    }
}

