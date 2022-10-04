private void simpleButton38_Click( object sender, EventArgs e )
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
   
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
   
             saveFileDialog1.CreatePrompt = true;
             saveFileDialog1.OverwritePrompt = true;
   
             saveFileDialog1.FileName = "세미나신청자";
             saveFileDialog1.DefaultExt = "xls";
             saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
             saveFileDialog1.InitialDirectory = "c:\\";
   
   
   
             DialogResult result = saveFileDialog1.ShowDialog();
   
   
             // 파일 저장 다이얼로그에서 선택이 된 후
             if (result == DialogResult.OK)
             {
                 try
                 {
                     object missingType = Type.Missing;
   
                     Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                     Microsoft.Office.Interop.Excel.Workbook excelBook = excelApp.Workbooks.Add(missingType);
                     //Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets.Add(missingType, missingType, missingType, missingType);
                     Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Sheets["Sheet1"];
                     excelApp.Visible = false;
   
   
   
                     // 사용 grid의 Row 갯수, 마지막 빈줄이 있어서 -1을 하였는데
   
                     // 설정에 따라서 마지막 빈줄이 없다면 -1이 필요 없음
   
                     for (int i = 0; i < this.dgvM1.RowCount -1 ; i++)
                     {
                         for (int j = 1; j < this.dgvM1.ColumnCount; j++)
                         {
                             if (i == 0)
                             {
                                 // Data Grid View Header, 첫줄은 Header 를 찍고
                                 excelWorksheet.Cells[1, j ] = this.dgvM1.Columns[j].HeaderText;
   
                                 excelWorksheet.Cells.NumberFormat = "@";//text 형식
                             }
   
                             // Data Grid View Value, 두번째 줄부터 Data를 찍고
                             excelWorksheet.Cells[i + 2, j] = this.dgvM1.Rows[i].Cells[j].Value.ToString();
                         }
   
                     }
   
                     // Excel 관련 함수들의 인수는 missingType을 쓰는 경우와 bool type, null 등도
   
                     // 쓰여진 것을 보았는데 missingType이 무난한(?) 듯. 더 찾아봐야 할듯 ^^;
   
                     excelBook.SaveAs(@saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missingType, missingType, missingType, missingType,
                             Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, missingType, missingType, missingType, missingType, missingType);
   
                     excelBook.Close(false, missingType, missingType);
   
   
   
                     System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
   
                     System.Windows.Forms.MessageBox.Show("저장성공!!");
                 }
                 catch (Exception ex)
                 {
                     System.Windows.Forms.MessageBox.Show("저장실패!!");
                     System.Windows.Forms.MessageBox.Show(ex.ToString());
                 }
   
             }
