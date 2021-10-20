using SampleApp.Models;
using System.Collections.Generic;

namespace SampleApp.Repositories
{
    public interface IReadonlyRepository
    {
        public List<SampleModel> GetList();

        public void PushNew(SampleModel sampleModel);
        public void PushToUpdate(SampleModel sampleModel);
    }
}
