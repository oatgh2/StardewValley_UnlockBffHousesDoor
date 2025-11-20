using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlockBffHousesDoor.Utils
{
  public class StringfiedList
  {
    public StringfiedList(string separator, IEnumerable<string> values)
    {
      Separator = separator ?? ",";
      Value = string.Join(Separator, values);
    }

    public StringfiedList(string separator, string values)
    {
      Value = values;
      Separator = separator ?? ",";
    }

    public string Value { get; private set; }
    public string Separator { get; }

    public IEnumerable<string> Get()
    {
      return string.IsNullOrWhiteSpace(Value) ? new List<string>() : Value.Split(Separator, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
    }

    public void Add(string value)
    {
      HashSet<string> listInstance = Get().ToHashSet();
      listInstance.Add(value);
      Value = string.Join(Separator, listInstance);
    }

    public override string ToString()
    {
      return Value;
    }
  }
}
