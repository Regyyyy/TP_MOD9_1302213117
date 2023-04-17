namespace tpmod9_1302213117
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string nama, string nim)
        {
            this.nama = nama;
            this.nim = nim;
        }
    }
}
