

using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using Wisej.Web;
using AIT_Oracle_SQL;
using AIT_OracleClient;

using System.Collections;
using System.Data;


namespace WisejWebDesktopApplication4
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetJupsu()
        {
            AIT_Base_Function.clsAITFunction FUN = new AIT_Base_Function.clsAITFunction();
            clsAITOracleClient ORACLIENT = new clsAITOracleClient();

            using (clsAITOracleSql ORASQL = new clsAITOracleSql())
            {
                ORASQL.ALISTSQL.Clear();
                ORASQL.MakeSQL();
                ORASQL.SQL.Append("   SELECT SNAME         \r\n");
                ORASQL.SQL.Append("   FROM TWOPD_JUPMST                  \r\n");
                ORASQL.SQL.Append("   WHERE DEPTCODE = 'OS'                    \r\n");
                ORASQL.SQL.Append("   AND GBJIN='1'                    \r\n");
                ORASQL.SQL.Append("      AND TRUNC(JTIME,'DD')='2020/05/11'                   \r\n");
                ORASQL.SQL.Append("   ORDER BY JTIME                    \r\n");

                ORASQL.OpenDS();
             //   ORASQL.AddBindArrayListinOneInout(":PTNO", clsAITOracleSql.ORADbType.Char, clsComm.PTNO, clsAITOracleSql.ORAInput.Input);
                ORASQL.AddSQLArrayList(ORASQL.CompressString(FUN.Encrypt(ORASQL.SQL.ToString())), "DUAL", ORASQL.ALISTBIND, true, FUN.GetPcIp(), FUN.GetPcName(), FUN.GetProgramName());
                ORASQL.ALISTDS = (ArrayList)(FUN.ByteArrayToObject(ORACLIENT.MRUNSELECT(ORASQL.ALISTSQL)));

                //int intCnt =  ORACLIENT.MEXECUTESQL(ORASQL.ALISTSQL);
                if (ORASQL.ALISTDS != null)
                {
                    for (int i = 0; i < ORASQL.ALISTDS.Count; i++)
                    {
                        DataSet DsResult = new DataSet();
                        DsResult = ORASQL.DecompressDataSet((byte[])ORASQL.ALISTDS[i]);
                        if (DsResult != null)
                        {
                            if (DsResult.Tables[0].Rows.Count > 0)
                            {

                                for (int r = 0; r < DsResult.Tables[0].Rows.Count; r++)
                                {
                                    //  comboBox1.Items.Add(DsResult.Tables[0].Rows[r][0].ToString() + "." + DsResult.Tables[0].Rows[r][1].ToString());
                                   // dataGridView1.Rows.Add(new string[3] { DsResult.Tables[0].Rows[r][0].ToString(), "0", null });
//
                                }
                              
                            }
                        }
                    }
                }
                ORASQL.CloseSQL();
                ORASQL.CloseBIND();
                ORASQL.CloseDS();
            }
            FUN = null;
            ORACLIENT = null;
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            label1.Parent=this;

        }

      private void Window1_Paint(object sender, PaintEventArgs e)
        {
            float angle = (float)(Math.PI / 2); // 90도

            // 회전시킬 중심점 설정
            float centerX = ClientSize.Width / 2;
            float centerY = ClientSize.Height / 2;

            // 회전 매트릭스 생성
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle * 180 / (float)Math.PI, new PointF(centerX, centerY));

            // 그래픽 객체 설정
            e.Graphics.Transform = matrix;

            // 그래픽에 그리기
            e.Graphics.DrawString("Rotated Form", Font, Brushes.Black, 0, 0);
        }
    }
}
