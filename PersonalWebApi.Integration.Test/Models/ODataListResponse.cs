using System.Collections.Generic;

namespace PersonalWebApi.Integration.Test.Models
{
    public class ODataListResponse<T>
    {
        public List<T> Value { get; set; }
    }
}
