using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}