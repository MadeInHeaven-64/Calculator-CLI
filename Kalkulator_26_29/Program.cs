using System;

class Kalkulator_26_29
{
    static void Main()
    {
        string mengulang_26_29;
        do
        {
            int angka1_26_29;
            int angka2_26_29;
            string operasi_26_29;
            double answer_26_29;
            

            {
                // PEMBUAT KALKULATOR
                Console.WriteLine(" === Membuat Kalkulator Dasar Dengan C# ===");
                Console.WriteLine(" ===    Kalkulator Ini Di Buat Oleh     ===");
                Console.WriteLine();
                Console.WriteLine("Rasya Dika Pratama   | Absen 26 | Kelas X PPLG 5");
                Console.WriteLine("Sofwan Nuha Al Faruq | Absen 29 | Kelas X PPLG 5");
                Console.WriteLine();

                // PROGRAM KALKULATOR
                Console.Write("Masukan angka pertama = ");
                angka1_26_29 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Pilih Operasi salah satu ");
                Console.WriteLine("Tambah          =  +");
                Console.WriteLine("Kurang          =  -");
                Console.WriteLine("Bagi            =  /");
                Console.WriteLine("Kali            =  *");
                Console.WriteLine("pangkat         =  ^");
                Console.WriteLine("Sisa Hasil Bagi =  %");
                Console.WriteLine();
                Console.Write("Masukan Operasi = ");
                operasi_26_29 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Masukan Angka Kedua = ");
                angka2_26_29 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // SWITCH CASE KALKULATOR
                switch (operasi_26_29)
                {
                    case "-" or "kurang":
                        answer_26_29 = angka1_26_29 - angka2_26_29;
                        Console.WriteLine("Hasil Dari " + angka1_26_29 + " " + operasi_26_29 + " " + angka2_26_29 + " Adalah = " + answer_26_29);
                        break;

                    case "+" or "tambah":
                        answer_26_29 = angka1_26_29 + angka2_26_29;
                        Console.WriteLine("Hasil Dari " + angka1_26_29 + " " + operasi_26_29 + " " + angka2_26_29 + " Adalah = " + answer_26_29);
                        break;

                    case "/" or "bagi":
                        answer_26_29 = angka1_26_29 / angka2_26_29;
                        Console.WriteLine("Hasil Dari " + angka1_26_29 + " " + operasi_26_29 + " " + angka2_26_29 + " Adalah = " + answer_26_29);
                        break;

                    case "*" or "kali":
                        answer_26_29 = angka1_26_29 * angka2_26_29;
                        Console.WriteLine("Hasil Dari " + angka1_26_29 + " " + operasi_26_29 + " " + angka2_26_29 + " Adalah = " + answer_26_29);
                        break;

                    case "^" or "pangkat":
                        answer_26_29 = Math.Pow(angka1_26_29, angka2_26_29);
                        Console.WriteLine("Hasil Dari " + angka1_26_29 + " " + operasi_26_29 + " " + angka2_26_29 + " Adalah = " + answer_26_29);
                        break;

                    case "%" or "sisa hasil bagi":
                        answer_26_29 = angka1_26_29 % angka2_26_29;
                        Console.WriteLine("Hasil Dari Sisa Bagi " + angka1_26_29 + " " + operasi_26_29 + " " + angka2_26_29 + " Adalah = " + answer_26_29);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Angka Atau Operasi Yang Dimasukan Tidak Ada. Mohon Menghitung Ulang");
                        break;
                }

            }
            // Looping
            Console.WriteLine();
            Console.Write("Mau mengulangi Kalkulator Jika Mau Tekan Y Jika Tidak N = ");
            mengulang_26_29 = Console.ReadLine();

            Console.WriteLine();

        }   while (mengulang_26_29 == "y" || mengulang_26_29 == "Y");


            if (mengulang_26_29 == "y" || mengulang_26_29 == "Y")
            {
                Console.WriteLine();
            }
            else if (mengulang_26_29 == "n" || mengulang_26_29 == "N")
            {
                Console.WriteLine("Terimakasih Telah Menggunakan Kalkulator");
            }
            else
            {
                Console.WriteLine("Huruf yang di Masukan Salah");
            }

    }
}