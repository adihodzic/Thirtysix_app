namespace Thirtysix_app.WebAPI.Database
{
    public class Bicikli
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Model { get; set; }
        public string TipBicikla { get; set; }
        public byte[] Slika { get; set; }

    }
}
