#region ini 입력 메소드
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion

        string model = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            model = txt_Model.Text;
            // ini파일에 등록
            // WritePrivateProfileString("카테고리", "Key값", "Value", "저장할 경로");
            WritePrivateProfileString("Setting", "NAME", txt_Name.Text, Application.StartupPath + @"\" + model + ".ini");
            WritePrivateProfileString("Setting", "AGE", txt_Age.Text, Application.StartupPath + @"\" + model + ".ini");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model = txt_Model.Text;
            // ini값을 집어넣을 변수 선언
            StringBuilder Name = new StringBuilder();
            StringBuilder Age = new StringBuilder();

            // ini파일에서 데이터를 불러옴
            // GetPrivateProfileString("카테고리", "Key값", "기본값", "저장할 변수", "불러올 경로");
            GetPrivateProfileString("Setting", "NAME", "", Name, 32, Application.StartupPath + @"\" + model + ".ini");
            GetPrivateProfileString("Setting", "AGE", "", Age, 32, Application.StartupPath + @"\" + model + ".ini");

            // 텍스트박스에 ini파일에서 가져온 데이터를 넣는다
            txt_Name.Text = Name.ToString();
            txt_Age.Text = Age.ToString();
            
        }
