namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    public partial class FormThemSach : Form
    {
        public FormThemSach()
        {
            InitializeComponent();
        }
        private void formThemNhanVien_Load(object sender, EventArgs e)
        {
            // Thể loại giả dữ liệu
            checkedListBoxTheLoai.Items.Add("Văn học");
            checkedListBoxTheLoai.Items.Add("Khoa học");
            checkedListBoxTheLoai.Items.Add("Thiếu nhi");
            checkedListBoxTheLoai.Items.Add("Tâm lý");
            checkedListBoxTheLoai.Items.Add("Văn học");
            checkedListBoxTheLoai.Items.Add("Khoa học");
            checkedListBoxTheLoai.Items.Add("Thiếu nhi");
            checkedListBoxTheLoai.Items.Add("Tâm lý");

            // Tác giả giả dữ liệu
            checkedListBoxTacGia.Items.Add("Nguyễn Nhật Ánh");
            checkedListBoxTacGia.Items.Add("Paulo Coelho");
            checkedListBoxTacGia.Items.Add("J.K. Rowling");
        }
    }
}
