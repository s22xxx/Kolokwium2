namespace KOl2_02
{
    public class GET_DTO
    {
        public int Code { get; set; }
        public string Mess { get; set; }

        public GET_DTO(int code, string mess)
        {
            Code = code;
            Mess = mess;
        }
    }
}
