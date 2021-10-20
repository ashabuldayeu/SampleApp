using SampleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp.Repositories
{
    public class WriteRepository : IWriteRepository
    {
        private readonly List<SampleModel> _memoryStore =  new List<SampleModel>();
        public int Add(SampleModel sampleModel)
        {
            if (_memoryStore.Any())
            {
                var lastId = _memoryStore.LastOrDefault().Id;
                sampleModel.Id = lastId + 1;
            }
            else
            {
                sampleModel.Id = 1;
            }
            _memoryStore.Add(sampleModel);

            return sampleModel.Id;
        }

        public void Update(SampleModel sampleModel)
        {
            var model = _memoryStore.FirstOrDefault(s => s.Id == sampleModel.Id);

            model.OtherValue = sampleModel.OtherValue;

            model.SomeValue = sampleModel.SomeValue;
        }
    }
}
