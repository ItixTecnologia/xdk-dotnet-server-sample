using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using XDK.Data.Abstractions;
using XDK.Sample.Mobile.Maui.Persistence;
using XDK.Sample.Mobile.Maui.Stores;

namespace XDK.Sample.Mobile.Maui
{
    public partial class MainPage : ContentPage
    {
        private readonly TestStore _testStore;
        private readonly IUnitOfWork _unitOfWork;
        private Guid recordId;

        public MainPage(TestStore testStore, IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _testStore = testStore;
            _unitOfWork = unitOfWork;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var model = await _testStore.Test();
            var rec = _unitOfWork.GetRepository<TestEntity>().Add(new TestEntity
            {
                Name = model.Name,
                Description = model.Description
            });

            _unitOfWork.SaveChanges();

            recordId = rec.Id;
        }

        private void OnLoadClicked(object sender, EventArgs e)
        {
            var record = _unitOfWork.GetRepository<TestEntity>().Find(recordId);
            CounterLabel.Text = $"Nome: {record.Name}; Desc: {record.Description}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
