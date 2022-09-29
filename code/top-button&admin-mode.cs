#region 상단버튼
        private void mini_kenb_Click(object sender, EventArgs e)   //  최소화
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exit_kenb_Click(object sender, EventArgs e)   //  닫기
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void title_kenlb_MouseDown(object sender, MouseEventArgs e) //  레이블 드래그
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

#region 관리자모드 단축키 Ctrl+Q / W
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = keyData & ~(Keys.Shift | Keys.Control);
            switch (key)
            {
                case Keys.Q://
                    if ((keyData & Keys.Control) != 0)
                    {
                        xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
                    }
                    break;
                case Keys.W://
                    if ((keyData & Keys.Control) != 0)
                    {
                        xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
