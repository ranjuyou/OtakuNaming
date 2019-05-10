using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        string ResultName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //
            if(this.rbM1.Checked) ResultName += "츠키노";
            else if (this.rbM2.Checked) ResultName += "아야노";
            else if (this.rbM3.Checked) ResultName += "소라노";
            else if (this.rbM4.Checked) ResultName += "미즈노";
            else if (this.rbM5.Checked) ResultName += "하나노";
            else if (this.rbM6.Checked) ResultName += "우츄우노";
            else if (this.rbM7.Checked) ResultName += "타요노";
            else if (this.rbM8.Checked) ResultName += "호시노";
            else if (this.rbM9.Checked) ResultName += "오오모리노";
            else if (this.rbM10.Checked) ResultName += "카케노";
            else if (this.rbM11.Checked) ResultName += "덴노";
            else if (this.rbM12.Checked) ResultName += "유키노";
            else ResultName += "NULL";

            //
            if (this.rbD1.Checked) ResultName += " 카케라";
            else if (this.rbD2.Checked) ResultName += " 텐시";
            else if (this.rbD3.Checked) ResultName += " 나미다";
            else if (this.rbD4.Checked) ResultName += " 차카시";
            else if (this.rbD5.Checked) ResultName += " 유메";
            else if (this.rbD6.Checked) ResultName += " 코코로";
            else if (this.rbD7.Checked) ResultName += " 시즈쿠";
            else if (this.rbD8.Checked) ResultName += " 요세이";
            else if (this.rbD9.Checked) ResultName += " 온가쿠";
            else if (this.rbD10.Checked) ResultName += " 히카리";
            else if (this.rbD11.Checked) ResultName += " 사메";
            else if (this.rbD12.Checked) ResultName += " 켓쇼";
            else if (this.rbD13.Checked) ResultName += " 사사야키";
            else if (this.rbD14.Checked) ResultName += " 오츠케";
            else if (this.rbD15.Checked) ResultName += " 오마지나이";
            else if (this.rbD16.Checked) ResultName += " 이츠와리";
            else if (this.rbD17.Checked) ResultName += " 이노리";
            else if (this.rbD18.Checked) ResultName += " 네코";
            else if (this.rbD19.Checked) ResultName += " 미치시루베";
            else if (this.rbD20.Checked) ResultName += " 쿠마";
            else if (this.rbD21.Checked) ResultName += " 호고샤";
            else if (this.rbD22.Checked) ResultName += " 마호";
            else if (this.rbD23.Checked) ResultName += " 타카라";
            else if (this.rbD24.Checked) ResultName += " 타마시";
            else if (this.rbD25.Checked) ResultName += " 요카이";
            else if (this.rbD26.Checked) ResultName += " 키츠네";
            else if (this.rbD27.Checked) ResultName += " 오오카미";
            else if (this.rbD28.Checked) ResultName += " 츠바사";
            else if (this.rbD29.Checked) ResultName += " 오미야게";
            else if (this.rbD30.Checked) ResultName += " 카이토";
            else if (this.rbD31.Checked) ResultName += " 하카이샤";
            else ResultName += "NULL";

            if (ResultName.Contains("NULL") ||
                (this.rbM2.Checked && (this.rbD30.Checked || this.rbD31.Checked) ||
                ((this.rbM4.Checked || this.rbM6.Checked || this.rbM9.Checked || this.rbM11.Checked)
                    && this.rbD31.Checked)))
            {
                MessageBox.Show("제대로 입력하세요.", "결과");
                ResultName = "";
            }
            else
            {
                MessageBox.Show("당신의 이름은 \"" + ResultName + "\" 입니다.", "결과");
                ResultName = "";
            }
        }
    }
}
