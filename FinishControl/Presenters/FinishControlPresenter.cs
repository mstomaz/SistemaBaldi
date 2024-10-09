using FinishControl.Repositories;
using FinishControl.Views;

namespace FinishControl.Presenters
{
    public class FinishControlPresenter
    {
        private IFinishControlMainView view;
        private FinishControlRepository repository;
        private BindingSource bindingSource;

        public FinishControlPresenter(IFinishControlMainView view, FinishControlRepository repository)
        {
            this.view = view;
            this.repository = repository;
            InitializeGrid();
        }

        public void InitializeGrid()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = repository.PopulateFinishControlGrid();
            view.prodControlGrid.DataSource = bindingSource;
        }
    }
}
