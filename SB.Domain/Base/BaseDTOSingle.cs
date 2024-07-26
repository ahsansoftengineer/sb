using System.Net;

namespace SB.Domain.Base
{
  public class BaseDtoSingle<T>
  {
    public T? Record { get; set; }
    public HttpStatusCode Status { get; set; }
  }
}
