using SampleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp.Repositories
{
    public class ReadonlyRepository : IReadonlyRepository
    {
        private readonly List<SampleModel> _memoryStore = new List<SampleModel>();
        public List<SampleModel> GetList()
        {
            return _memoryStore;
        }

        public void PushNew(SampleModel sampleModel)
        {
            _memoryStore.Add(sampleModel);
        }

        public void PushToUpdate(SampleModel sampleModel)
        {
            var model = _memoryStore.FirstOrDefault(s => s.Id == sampleModel.Id);

            model.OtherValue = sampleModel.OtherValue;

            model.SomeValue = sampleModel.SomeValue;
        }
    }
}
