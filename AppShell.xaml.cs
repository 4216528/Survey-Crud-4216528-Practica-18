using Survey_Crud_4216528.Views;

using Survey_Crud_4216528.Models;

using Survey_Crud_4216528.Data;

namespace Survey_Crud_4216528

{

    public partial class AppShell : Shell

    {

        public AppShell()

        {

            InitializeComponent();

            Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));

        }

    }

}