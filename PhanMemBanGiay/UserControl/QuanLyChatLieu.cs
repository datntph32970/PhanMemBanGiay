using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemBanGiay
{
    public partial class QuanLyChatLieu : UserControl
    {
        ChatLieuService _ser = new ChatLieuService();
        List<Chatlieu> _lstChatLieu;
        int idCicked;
        public QuanLyChatLieu()
        {
            InitializeComponent();
        }

        private void QuanLyChatLieu_Load(object sender, EventArgs e)
        {
            LoadDataGird(null, null);
        }
        public void LoadDataGird(string? txtTimKiem,string? searchText)
        {
            dgvChatLieu.Rows.Clear();

            dgvChatLieu.ColumnCount = 5;
            dgvChatLieu.Columns[0].Name = "STT";
            dgvChatLieu.Columns[1].Name = "Tên chất liệu";
            dgvChatLieu.Columns[2].Name = "Mô tả chất liệu";
            dgvChatLieu.Columns[3].Name = "Locked";
            dgvChatLieu.Columns[4].Name = "ID";
            dgvChatLieu.Columns[4].Visible = false;

            _lstChatLieu = _ser.GetAll(txtTimKiem, searchText);

            foreach (var Obj in _lstChatLieu)
            {
                int stt = _lstChatLieu.IndexOf(Obj) + 1;

                dgvChatLieu.Rows.Add(stt,
                    Obj.Machatlieu,
                    Obj.Tenchatlieu,
                    Obj.Mota,
                    Obj.Locked
                    );
            }
            dgvChatLieu.Columns[0].Width = 150;
            dgvChatLieu.Columns[1].Width = 300;
            dgvChatLieu.Columns[2].Width = 300;
            dgvChatLieu.Columns[3].Width = 300;
        }
    }
}
