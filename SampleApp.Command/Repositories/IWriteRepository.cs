using SampleApp.Models;

namespace SampleApp.Repositories
{
    public interface IWriteRepository
    {
        public int Add(SampleModel sampleModel);
        public void Update(SampleModel sampleModel);
    }
}
