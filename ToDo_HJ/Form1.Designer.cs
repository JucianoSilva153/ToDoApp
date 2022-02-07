
namespace ToDo_HJ
{
    partial class ToDo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gestao_BDDataSet = new ToDo_HJ.Gestao_BDDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new ToDo_HJ.Gestao_BDDataSetTableAdapters.ProdutosTableAdapter();
            this.TabPaginas = new MaterialSkin.Controls.MaterialTabControl();
            this.Lista = new System.Windows.Forms.TabPage();
            this.dgv_tarefas = new Guna.UI.WinForms.GunaDataGridView();
            this.tarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concluida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_Menu = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.verTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.base_de_DadosDataSet1 = new ToDo_HJ.Base_de_DadosDataSet1();
            this.View_Tarefa = new System.Windows.Forms.TabPage();
            this.cmd_Menu = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.concluirtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_de_DadosDataSet = new ToDo_HJ.Base_de_DadosDataSet();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.tarefasTableAdapter = new ToDo_HJ.Base_de_DadosDataSetTableAdapters.TarefasTableAdapter();
            this.tarefasTableAdapter1 = new ToDo_HJ.Base_de_DadosDataSet1TableAdapters.TarefasTableAdapter();
            this.lbl_textoMain = new System.Windows.Forms.Label();
            this.txt_tarefa = new Guna.UI.WinForms.GunaTextBox();
            this.txt_descricaoTarefa = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddTarefa = new Guna.UI.WinForms.GunaButton();
            this.chkb_conluido = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_caracteres = new System.Windows.Forms.Label();
            this.lbl_caracteres2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestao_BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.TabPaginas.SuspendLayout();
            this.Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarefas)).BeginInit();
            this.cms_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_DadosDataSet1)).BeginInit();
            this.View_Tarefa.SuspendLayout();
            this.cmd_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_DadosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.gunaControlBox2);
            this.panelTop.Controls.Add(this.gunaControlBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(566, 40);
            this.panelTop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "ToDo App";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(478, 1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.LightSteelBlue;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(38, 38);
            this.gunaControlBox2.TabIndex = 5;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(522, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.LightSteelBlue;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(38, 38);
            this.gunaControlBox1.TabIndex = 4;
            // 
            // gestao_BDDataSet
            // 
            this.gestao_BDDataSet.DataSetName = "Gestao_BDDataSet";
            this.gestao_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.gestao_BDDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // TabPaginas
            // 
            this.TabPaginas.Controls.Add(this.Lista);
            this.TabPaginas.Controls.Add(this.View_Tarefa);
            this.TabPaginas.Depth = 0;
            this.TabPaginas.Location = new System.Drawing.Point(-5, 42);
            this.TabPaginas.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabPaginas.Name = "TabPaginas";
            this.TabPaginas.SelectedIndex = 0;
            this.TabPaginas.Size = new System.Drawing.Size(576, 560);
            this.TabPaginas.TabIndex = 4;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.dgv_tarefas);
            this.Lista.Location = new System.Drawing.Point(4, 22);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(3);
            this.Lista.Size = new System.Drawing.Size(568, 534);
            this.Lista.TabIndex = 0;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // dgv_tarefas
            // 
            this.dgv_tarefas.AllowUserToAddRows = false;
            this.dgv_tarefas.AllowUserToDeleteRows = false;
            this.dgv_tarefas.AllowUserToResizeColumns = false;
            this.dgv_tarefas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_tarefas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tarefas.AutoGenerateColumns = false;
            this.dgv_tarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tarefas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tarefas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tarefas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tarefas.ColumnHeadersHeight = 21;
            this.dgv_tarefas.ColumnHeadersVisible = false;
            this.dgv_tarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarefaDataGridViewTextBoxColumn,
            this.concluida,
            this.dataDataGridViewTextBoxColumn});
            this.dgv_tarefas.ContextMenuStrip = this.cms_Menu;
            this.dgv_tarefas.DataSource = this.tarefasBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tarefas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tarefas.EnableHeadersVisualStyles = false;
            this.dgv_tarefas.GridColor = System.Drawing.Color.White;
            this.dgv_tarefas.Location = new System.Drawing.Point(3, 3);
            this.dgv_tarefas.MultiSelect = false;
            this.dgv_tarefas.Name = "dgv_tarefas";
            this.dgv_tarefas.ReadOnly = true;
            this.dgv_tarefas.RowHeadersVisible = false;
            this.dgv_tarefas.RowTemplate.Height = 30;
            this.dgv_tarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tarefas.Size = new System.Drawing.Size(562, 528);
            this.dgv_tarefas.TabIndex = 3;
            this.dgv_tarefas.TabStop = false;
            this.dgv_tarefas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_tarefas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tarefas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_tarefas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_tarefas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_tarefas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_tarefas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tarefas.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgv_tarefas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgv_tarefas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_tarefas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_tarefas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tarefas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_tarefas.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_tarefas.ThemeStyle.ReadOnly = true;
            this.dgv_tarefas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tarefas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tarefas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dgv_tarefas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SteelBlue;
            this.dgv_tarefas.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_tarefas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_tarefas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.SteelBlue;
            // 
            // tarefaDataGridViewTextBoxColumn
            // 
            this.tarefaDataGridViewTextBoxColumn.DataPropertyName = "tarefa";
            this.tarefaDataGridViewTextBoxColumn.FillWeight = 180F;
            this.tarefaDataGridViewTextBoxColumn.HeaderText = "Tarefa";
            this.tarefaDataGridViewTextBoxColumn.Name = "tarefaDataGridViewTextBoxColumn";
            this.tarefaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concluida
            // 
            this.concluida.DataPropertyName = "concluida";
            this.concluida.FillWeight = 130F;
            this.concluida.HeaderText = "Concluida";
            this.concluida.Name = "concluida";
            this.concluida.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cms_Menu
            // 
            this.cms_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.cms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTarefaToolStripMenuItem,
            this.excluirTarefaToolStripMenuItem,
            this.novaToolStripMenuItem});
            this.cms_Menu.Name = "cms_Menu";
            this.cms_Menu.RenderStyle.ArrowColor = System.Drawing.Color.LightSteelBlue;
            this.cms_Menu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cms_Menu.RenderStyle.ColorTable = null;
            this.cms_Menu.RenderStyle.RoundedEdges = true;
            this.cms_Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cms_Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.cms_Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cms_Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cms_Menu.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cms_Menu.ShowImageMargin = false;
            this.cms_Menu.Size = new System.Drawing.Size(95, 74);
            // 
            // verTarefaToolStripMenuItem
            // 
            this.verTarefaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.verTarefaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verTarefaToolStripMenuItem.Name = "verTarefaToolStripMenuItem";
            this.verTarefaToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.verTarefaToolStripMenuItem.Text = "Ver";
            this.verTarefaToolStripMenuItem.ToolTipText = "Ver a Tarefa Selecionada";
            this.verTarefaToolStripMenuItem.Click += new System.EventHandler(this.verTarefaToolStripMenuItem_Click);
            // 
            // excluirTarefaToolStripMenuItem
            // 
            this.excluirTarefaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.excluirTarefaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excluirTarefaToolStripMenuItem.Name = "excluirTarefaToolStripMenuItem";
            this.excluirTarefaToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.excluirTarefaToolStripMenuItem.Text = "Excluir";
            this.excluirTarefaToolStripMenuItem.ToolTipText = "Excluir a Tarefa Selecionada";
            this.excluirTarefaToolStripMenuItem.Click += new System.EventHandler(this.eliminarTarefaToolStripMenuItem_Click);
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.AutoSize = false;
            this.novaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.novaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novaToolStripMenuItem.Text = "Nova";
            this.novaToolStripMenuItem.ToolTipText = "Adicionar nova Tarefa";
            this.novaToolStripMenuItem.Click += new System.EventHandler(this.novaToolStripMenuItem_Click);
            // 
            // tarefasBindingSource1
            // 
            this.tarefasBindingSource1.DataMember = "Tarefas";
            this.tarefasBindingSource1.DataSource = this.base_de_DadosDataSet1;
            // 
            // base_de_DadosDataSet1
            // 
            this.base_de_DadosDataSet1.DataSetName = "Base_de_DadosDataSet1";
            this.base_de_DadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_Tarefa
            // 
            this.View_Tarefa.BackColor = System.Drawing.Color.White;
            this.View_Tarefa.ContextMenuStrip = this.cmd_Menu;
            this.View_Tarefa.Controls.Add(this.lbl_caracteres2);
            this.View_Tarefa.Controls.Add(this.lbl_caracteres);
            this.View_Tarefa.Controls.Add(this.label2);
            this.View_Tarefa.Controls.Add(this.chkb_conluido);
            this.View_Tarefa.Controls.Add(this.btn_AddTarefa);
            this.View_Tarefa.Controls.Add(this.label4);
            this.View_Tarefa.Controls.Add(this.label3);
            this.View_Tarefa.Controls.Add(this.txt_descricaoTarefa);
            this.View_Tarefa.Controls.Add(this.txt_tarefa);
            this.View_Tarefa.Controls.Add(this.lbl_textoMain);
            this.View_Tarefa.Location = new System.Drawing.Point(4, 22);
            this.View_Tarefa.Name = "View_Tarefa";
            this.View_Tarefa.Padding = new System.Windows.Forms.Padding(3);
            this.View_Tarefa.Size = new System.Drawing.Size(568, 534);
            this.View_Tarefa.TabIndex = 1;
            this.View_Tarefa.Text = "View Tarefa";
            // 
            // cmd_Menu
            // 
            this.cmd_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.cmd_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirtoolStripMenuItem1,
            this.cancelartoolStripMenuItem});
            this.cmd_Menu.Name = "cms_Menu";
            this.cmd_Menu.RenderStyle.ArrowColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_Menu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmd_Menu.RenderStyle.ColorTable = null;
            this.cmd_Menu.RenderStyle.RoundedEdges = true;
            this.cmd_Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmd_Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.cmd_Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmd_Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmd_Menu.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cmd_Menu.ShowImageMargin = false;
            this.cmd_Menu.Size = new System.Drawing.Size(109, 52);
            // 
            // concluirtoolStripMenuItem1
            // 
            this.concluirtoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.concluirtoolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.concluirtoolStripMenuItem1.Name = "concluirtoolStripMenuItem1";
            this.concluirtoolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.concluirtoolStripMenuItem1.Text = "Concluir";
            this.concluirtoolStripMenuItem1.ToolTipText = "Ver a Tarefa Selecionada";
            this.concluirtoolStripMenuItem1.Click += new System.EventHandler(this.concluirtoolStripMenuItem1_Click);
            // 
            // cancelartoolStripMenuItem
            // 
            this.cancelartoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelartoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cancelartoolStripMenuItem.Name = "cancelartoolStripMenuItem";
            this.cancelartoolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cancelartoolStripMenuItem.Text = "Cancelar";
            this.cancelartoolStripMenuItem.ToolTipText = "Excluir a Tarefa Selecionada";
            this.cancelartoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tarefasBindingSource
            // 
            this.tarefasBindingSource.DataMember = "Tarefas";
            this.tarefasBindingSource.DataSource = this.base_de_DadosDataSet;
            // 
            // base_de_DadosDataSet
            // 
            this.base_de_DadosDataSet.DataSetName = "Base_de_DadosDataSet";
            this.base_de_DadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelTop;
            // 
            // tarefasTableAdapter
            // 
            this.tarefasTableAdapter.ClearBeforeFill = true;
            // 
            // tarefasTableAdapter1
            // 
            this.tarefasTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_textoMain
            // 
            this.lbl_textoMain.AutoSize = true;
            this.lbl_textoMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textoMain.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_textoMain.Location = new System.Drawing.Point(132, 52);
            this.lbl_textoMain.Name = "lbl_textoMain";
            this.lbl_textoMain.Size = new System.Drawing.Size(282, 31);
            this.lbl_textoMain.TabIndex = 6;
            this.lbl_textoMain.Text = "Adicione uma Tarefa";
            // 
            // txt_tarefa
            // 
            this.txt_tarefa.BackColor = System.Drawing.Color.Transparent;
            this.txt_tarefa.BaseColor = System.Drawing.Color.White;
            this.txt_tarefa.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_tarefa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tarefa.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tarefa.FocusedBorderColor = System.Drawing.Color.LightSteelBlue;
            this.txt_tarefa.FocusedForeColor = System.Drawing.Color.SteelBlue;
            this.txt_tarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tarefa.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_tarefa.Location = new System.Drawing.Point(109, 168);
            this.txt_tarefa.MaxLength = 20;
            this.txt_tarefa.Name = "txt_tarefa";
            this.txt_tarefa.PasswordChar = '\0';
            this.txt_tarefa.Radius = 10;
            this.txt_tarefa.SelectedText = "";
            this.txt_tarefa.Size = new System.Drawing.Size(341, 40);
            this.txt_tarefa.TabIndex = 0;
            this.txt_tarefa.TextChanged += new System.EventHandler(this.txt_tarefa_TextChanged);
            // 
            // txt_descricaoTarefa
            // 
            this.txt_descricaoTarefa.BackColor = System.Drawing.Color.Transparent;
            this.txt_descricaoTarefa.BaseColor = System.Drawing.Color.White;
            this.txt_descricaoTarefa.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_descricaoTarefa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_descricaoTarefa.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_descricaoTarefa.FocusedBorderColor = System.Drawing.Color.LightSteelBlue;
            this.txt_descricaoTarefa.FocusedForeColor = System.Drawing.Color.SteelBlue;
            this.txt_descricaoTarefa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_descricaoTarefa.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_descricaoTarefa.Location = new System.Drawing.Point(109, 241);
            this.txt_descricaoTarefa.MaxLength = 300;
            this.txt_descricaoTarefa.Multiline = true;
            this.txt_descricaoTarefa.Name = "txt_descricaoTarefa";
            this.txt_descricaoTarefa.PasswordChar = '\0';
            this.txt_descricaoTarefa.Radius = 10;
            this.txt_descricaoTarefa.SelectedText = "";
            this.txt_descricaoTarefa.Size = new System.Drawing.Size(341, 166);
            this.txt_descricaoTarefa.TabIndex = 2;
            this.txt_descricaoTarefa.TextChanged += new System.EventHandler(this.txt_descricaoTarefa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(115, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tarefa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(115, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // btn_AddTarefa
            // 
            this.btn_AddTarefa.AnimationHoverSpeed = 0.07F;
            this.btn_AddTarefa.AnimationSpeed = 0.03F;
            this.btn_AddTarefa.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddTarefa.BaseColor = System.Drawing.Color.SteelBlue;
            this.btn_AddTarefa.BorderColor = System.Drawing.Color.Black;
            this.btn_AddTarefa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddTarefa.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddTarefa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_AddTarefa.ForeColor = System.Drawing.Color.White;
            this.btn_AddTarefa.Image = null;
            this.btn_AddTarefa.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddTarefa.Location = new System.Drawing.Point(194, 450);
            this.btn_AddTarefa.Name = "btn_AddTarefa";
            this.btn_AddTarefa.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue;
            this.btn_AddTarefa.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_AddTarefa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AddTarefa.OnHoverImage = null;
            this.btn_AddTarefa.OnPressedColor = System.Drawing.Color.SteelBlue;
            this.btn_AddTarefa.Radius = 10;
            this.btn_AddTarefa.Size = new System.Drawing.Size(160, 42);
            this.btn_AddTarefa.TabIndex = 10;
            this.btn_AddTarefa.Text = "Adicionar";
            this.btn_AddTarefa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddTarefa.Click += new System.EventHandler(this.btn_AddTarefa_Click);
            // 
            // chkb_conluido
            // 
            this.chkb_conluido.BaseColor = System.Drawing.Color.White;
            this.chkb_conluido.CheckedOffColor = System.Drawing.Color.LightSteelBlue;
            this.chkb_conluido.CheckedOnColor = System.Drawing.Color.SteelBlue;
            this.chkb_conluido.FillColor = System.Drawing.Color.White;
            this.chkb_conluido.Location = new System.Drawing.Point(118, 413);
            this.chkb_conluido.Name = "chkb_conluido";
            this.chkb_conluido.Size = new System.Drawing.Size(20, 20);
            this.chkb_conluido.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(137, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Concluida";
            // 
            // lbl_caracteres
            // 
            this.lbl_caracteres.AutoSize = true;
            this.lbl_caracteres.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_caracteres.Location = new System.Drawing.Point(404, 152);
            this.lbl_caracteres.Name = "lbl_caracteres";
            this.lbl_caracteres.Size = new System.Drawing.Size(30, 13);
            this.lbl_caracteres.TabIndex = 13;
            this.lbl_caracteres.Text = "0/20";
            // 
            // lbl_caracteres2
            // 
            this.lbl_caracteres2.AutoSize = true;
            this.lbl_caracteres2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_caracteres2.Location = new System.Drawing.Point(404, 225);
            this.lbl_caracteres2.Name = "lbl_caracteres2";
            this.lbl_caracteres2.Size = new System.Drawing.Size(36, 13);
            this.lbl_caracteres2.TabIndex = 14;
            this.lbl_caracteres2.Text = "0/300";
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 597);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.TabPaginas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestao_BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.TabPaginas.ResumeLayout(false);
            this.Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarefas)).EndInit();
            this.cms_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_DadosDataSet1)).EndInit();
            this.View_Tarefa.ResumeLayout(false);
            this.View_Tarefa.PerformLayout();
            this.cmd_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_DadosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Gestao_BDDataSet gestao_BDDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Gestao_BDDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private MaterialSkin.Controls.MaterialTabControl TabPaginas;
        private System.Windows.Forms.TabPage Lista;
        private Guna.UI.WinForms.GunaDataGridView dgv_tarefas;
        private System.Windows.Forms.TabPage View_Tarefa;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaContextMenuStrip cms_Menu;
        private System.Windows.Forms.ToolStripMenuItem verTarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private Guna.UI.WinForms.GunaContextMenuStrip cmd_Menu;
        private System.Windows.Forms.ToolStripMenuItem concluirtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelartoolStripMenuItem;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Base_de_DadosDataSet base_de_DadosDataSet;
        private System.Windows.Forms.BindingSource tarefasBindingSource;
        private Base_de_DadosDataSetTableAdapters.TarefasTableAdapter tarefasTableAdapter;
        private Base_de_DadosDataSet1 base_de_DadosDataSet1;
        private System.Windows.Forms.BindingSource tarefasBindingSource1;
        private Base_de_DadosDataSet1TableAdapters.TarefasTableAdapter tarefasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concluida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_caracteres2;
        private System.Windows.Forms.Label lbl_caracteres;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaMediumCheckBox chkb_conluido;
        private Guna.UI.WinForms.GunaButton btn_AddTarefa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txt_descricaoTarefa;
        private Guna.UI.WinForms.GunaTextBox txt_tarefa;
        private System.Windows.Forms.Label lbl_textoMain;
    }
}

