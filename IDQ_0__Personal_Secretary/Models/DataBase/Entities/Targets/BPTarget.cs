namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets
{
    public class BPTarget:Target
    {
        public int BuisnessProcessId { get; set; }
        public BuisnessProcess BP  { get; set; }
    }
}
