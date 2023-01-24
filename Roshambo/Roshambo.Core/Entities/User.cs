using Roshambo.Core.Entities.Base;

namespace Roshambo.Core.Entities
{
    public class User : EntityBase<int>
    {
        public string Username { get; set; }
    }
}
