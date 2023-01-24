using Roshambo.Core.Entities.Base;

namespace Roshambo.Core.Entities
{
    public class Game : EntityBase<int>
    {
        public string PlayerMove { get; set; }
        public string CpuMove { get; set; }
        public string Result { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

    }
}
