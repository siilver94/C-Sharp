#region 패턴 그랩, 트레인 버튼 동작
        private void btn_ImageGrab_Click(object sender, EventArgs e)
        {
            //mypm은 위에 CogPMAlignTool 타입으로 전역변수 선언 함
            mypm = (CogPMAlignTool)cogtoolgroup.Tools[2];
            ICogRecord tmpRecord;
            if (mypm.InputImage != null)
            {
                mypm.Pattern.TrainImage = mypm.InputImage;
                tmpRecord = mypm.CreateCurrentRecord();
                tmpRecord = tmpRecord.SubRecords["TrainImage"];
                cogRecordDisplay1.Record = tmpRecord;
            }
        }
        private void btn_Train_Click(object sender, EventArgs e)
        {
            mypm.Pattern.Train();
            CogSerializer.SaveObjectToFile(cogtoolgroup, savepath + modelnum + ".vpp", typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), CogSerializationOptionsConstants.Minimum);
            cogRecordDisplay1.Record = cogtoolgroup.CreateLastRunRecord().SubRecords[0];
        }
        #endregion
        #region 블랍 설정 버튼 동작
        private void btn_BlobSetting_Click(object sender, EventArgs e)
        {
            CogBlobTool myblob = (CogBlobTool)cogtoolgroup.Tools[3];
            ICogRecord tmpRecord;
            if (myblob.InputImage != null)
            {
                tmpRecord = myblob.CreateCurrentRecord();
               
                tmpRecord = tmpRecord.SubRecords["InputImage"];
                cogRecordDisplay1.Record = tmpRecord;
            }
        }
        private void btn_BlobSettingEnd_Click(object sender, EventArgs e)
        {
            CogSerializer.SaveObjectToFile(cogtoolgroup, savepath + modelnum + ".vpp", typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), CogSerializationOptionsConstants.Minimum);
            cogRecordDisplay1.Record = cogtoolgroup.CreateLastRunRecord().SubRecords[0];
        }
        #endregion
