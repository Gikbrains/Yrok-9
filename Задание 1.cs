using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            WIN32_FIND_DATA wfd;
            HANDLE hFile;

            HANDLE hOutput = GetStdHandle(STD_OUTPUT_HANDLE);
            CONSOLE_SCREEN_BUFFER_INFO SCRN_INFO;

            COORD pos;

            void show(char z[50]);
            void clr();
            void newf(char z[50]);
            char folder[30] = "C:/*.*";
            char text[30];
            char fil[30];

            int i1 = 0;
            int q = 1;
            int main()
            {
                int i = 0;

                show(folder);
                show(folder);

                while (q)
                {

                    cin >> i;
                    if (i < 7) cin >> folder;
                    switch (i)
                    {
                        case 1: show(folder); break;
                        case 2: newf(folder); break;
                        case 3: RemoveDirectory(folder); clr(); bre ak;
                        case 4: FILE* fp; fp = fopen(folder, "w"); fclose(fp); clr(); break;
                        case 5:
                            FILE* fp1; fp1 = fopen(folder, "r");
                            fscanf(fp1, "%s", &fil);
                            clr();
                            pos.X = 5;
                            pos.Y = 10;
                            SetConsoleCursorPosition(hOutput, po s);
                            SetConsoleTextAttribute(hOutput, 30);
                            cout << fil;
                            pos.X = 46;
                            pos.Y = 23;
                            fclose(fp1);
                            fp1 = fopen(folder, "w");
                            cin >> text;
                            fprintf(fp1, "%s", fil);
                            fprintf(fp1, "%s", text);
                            SetConsoleCursorPosition(hOutput, po s);
                            fclose(fp1);
                            break;
                        case 6: DeleteFile(folder); clr(); break;
                        case 7: q = 0; break;
                    }
                }


            }


            