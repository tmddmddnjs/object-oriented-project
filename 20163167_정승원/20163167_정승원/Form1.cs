using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20163167_정승원
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ㄱ
        int[,] answer1 = new int[5, 5] {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 } };
        //ㄴ
        int[,] answer2 = new int[5, 5]{
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1 } };
        //ㄷ
        int[,] answer3 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1 } };
        //ㄹ
        int[,] answer4 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1 } };
        //ㅁ
        int[,] answer5 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 } };
        //ㅂ
        int[,] answer6 = new int[5, 5]{
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 } };

        int[,] x1 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { -1, -1, -1, -1, 1 },
            { -1, -1, -1, -1, 1 },
            { -1, -1, -1, -1, 1 },
            { -1, -1, -1, -1, 1 } };
        int[,] x1T = new int[5, 5];

        int[,] x2 = new int[5, 5]{
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x2T = new int[5, 5];

        int[,] x3 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x3T = new int[5, 5];

        int[,] x4 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { -1, -1, -1, -1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, -1, -1, -1, -1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x4T = new int[5, 5];

        int[,] x5 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 1, -1, -1, -1, 1 },
            { 1, -1, -1, -1, 1 },
            { 1, -1, -1, -1, 1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x5T = new int[5, 5];

        int[,] x6 = new int[5, 5]{
            { 1, -1, -1, -1, 1 },
            { 1, -1, -1, -1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, -1, -1, -1, 1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x6T = new int[5, 5];

        int[,] W = new int[5, 5];
        int[,] B = new int[5, 5];
        int[,] Answer = new int[5, 5];

        private void click_button(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tag = int.Parse(btn.Tag.ToString());

            //tag가 1부터 5인 값들을
            if (tag <= 5)
            {
                //눌렀을 때 0으로 할지 1로 할지 결정
                if (B[0, tag - 1] == 1)
                {
                    btn.Text = " ";
                    //해당 위치의 숫자 결정
                    B[0, tag - 1] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[0, tag - 1] = 1;
                }
            }
            else if (tag <= 10)
            {
                if (B[1, tag - 6] == 1)
                {
                    btn.Text = " ";
                    B[1, tag - 6] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[1, tag - 6] = 1;
                }
            }
            else if (tag <= 15)
            {
                if (B[2, tag - 11] == 1)
                {
                    btn.Text = " ";
                    B[2, tag - 11] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[2, tag - 11] = 1;
                }
            }
            else if (tag <= 20)
            {
                if (B[3, tag - 16] == 1)
                {
                    btn.Text = " ";
                    B[3, tag - 16] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[3, tag - 16] = 1;
                }
            }
            else if (tag <= 25)
            {
                if (B[4, tag - 21] == 1)
                {
                    btn.Text = " ";
                    B[4, tag - 21] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[4, tag - 21] = 1;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //X의 전치행렬 채우고
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    x1T[i, j] = x1[j, i];
                    x2T[i, j] = x2[j, i];
                    x3T[i, j] = x3[j, i];
                    x4T[i, j] = x4[j, i];
                    x5T[i, j] = x5[i, j];
                    x6T[i, j] = x6[i, j];
                }
            }
            //x * xT 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        W[i, j] += (x1[i, k] * x1T[k, j]) + (x2[i, k] * x2T[k, j]) + (x3[i, k] * x3T[k, j]) + 
                            (x4[i, k] * x4T[k, j]) + (x5[i, k] * x5T[k, j]) + (x6[i, k] * x6T[k, j]);
                    }
                    if (i == j)
                        W[i, j] = W[i, j] - 6;
                }
            }
            // 가중치를 통해 인공지능 실행
            bool result = true;
            while (result)
            {
                // 입력값 * 가중치
                int i, j, k;
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        for (k = 0; k < 5; k++)
                        {
                            B[i, j] += B[i, k] * W[k, j];
                        }

                    }
                }
                // 활성화 함수
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        if (B[i, j] >= 0)
                            Answer[i, j] = 1;
                        else
                            Answer[i, j] = 0;
                    }
                }
                //체크
                if (CheckArr(answer1) == false)
                    result = false;
                else if (CheckArr(answer2) == false)
                    result = false;
                else if (CheckArr(answer3) == false)
                    result = false;
                else if (CheckArr(answer4) == false)
                    result = false;
                else if (CheckArr(answer5) == false)
                    result = false;
                else if (CheckArr(answer6) == false)
                    result = false;
            }


            // 값 표시하기
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Answer[i, j] == 1)
                        textBox1.Text += "1  ";
                    else
                        textBox1.Text += "0  ";
                }
                textBox1.Text += "\r\n";
            }
            label_text();
            clean();
        }
        public void label_text()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Answer[i, j] == answer1[i, j])
                    {
                        label1.Text = "ㄱ";
                    }
                    else if (Answer[i, j] == answer2[i, j])
                    {
                        label1.Text = "ㄴ";
                    }
                    else if(Answer[i,j] == answer3[i, j])
                    {
                        label1.Text = "ㄷ";
                    }
                    else if (Answer[i, j] == answer4[i, j])
                    {
                        label1.Text = "ㄹ";
                    }
                    else if (Answer[i, j] == answer5[i, j])
                    {
                        label1.Text = "ㅁ";
                    }
                    else if (Answer[i, j] == answer6[i, j])
                    {
                        label1.Text = "ㅂ";
                    }
                }
            }
        }
        public bool CheckArr(int[,] arr)
        {
            bool result = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Answer[i, j] != arr[i, j])
                    {
                        result = true;
                        return result;
                    }
                }
            }
            return false;
        }

        //확인 버튼 누른 후 글자 초기화하기
        public void clean()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    W[i, j] = 0;
                    B[i, j] = 0;
                    Answer[i, j] = 0;
                }
            }

            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";
            button27.Text = "";
            button28.Text = "";
            button29.Text = "";
            button30.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
            button34.Text = "";
            button35.Text = "";
        }
    }
}
