using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static ClientRest_085_IfanRizky.Program;

namespace ClientRest_085_IfanRizky
{
    class ClassData
    {
        public void getData()
        {
            //var type data yg tak peduli pada bentuk, tapi isinya
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);//dapet data
            /* for (int i = 0; i < data.Cont; i++)
             * {
             * Console.WriteLine(data[i].nama);
             * Console.WriteLine(data[i].nim);
             * Console.WriteLine(data[i].prodi);
             * Console.WriteLine(data[i].angkatan);
             *}
             /*/
         
            foreach (var mhs in data)
            {
                Console.WriteLine("NIM: " + mhs.nama);
                Console.WriteLine("Nama: " + mhs.nim);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
            }

            Console.ReadLine();
        }
    }
}
