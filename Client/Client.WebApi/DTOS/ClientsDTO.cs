namespace Client.WebApi.DTOS
{
    public class ClientsDTO
    {
        public int IdClient { get; set; }

        public string? NameClient { get; set; }

        public int? Ege { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Direction { get; set; }
    }
}
