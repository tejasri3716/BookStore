using Manager.Manager;
using Model.LabelModels;
using NUnit.Framework;
using Repository.Repository;
namespace FundooTest
{    public class LabelTest
    {
        [Test]
        public void AddLabelTest()
        {
            LabelRepository repository = new LabelRepository();
            LabelModel label = new LabelModel
            {
                LabelId = 1,
                LabelName = "Sample",
                NoteId = 1
            };
            Assert.IsNotNull(repository.AddLabel(label));
        }

        [Test]
        public void DeleteLabel()
        {
            LabelManager label = new LabelManager();
            var result = label.DeleteLabel(1);
            Assert.NotNull(result);
        }
    }
}