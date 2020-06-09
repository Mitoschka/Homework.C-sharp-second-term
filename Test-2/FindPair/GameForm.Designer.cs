namespace FindPair
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent(int sizeOfTable)
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timerForStepOfPlayer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel.ColumnCount = sizeOfTable;
            this.tableLayoutPanel.RowCount = sizeOfTable;
            for (int i = 0; i != sizeOfTable; ++i)
            {
                float width = 100 / (sizeOfTable);
                this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, width));
                this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, width));
            }

            for (int i = 0; i != sizeOfTable; ++i)
            {
                for (int j = 0; j != sizeOfTable; ++j)
                {
                    System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();
                    newLabel.BackColor = System.Drawing.Color.PeachPuff;
                    newLabel.Dock = System.Windows.Forms.DockStyle.Fill;
                    newLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    newLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    newLabel.Click += new System.EventHandler(this.clickOnLabel);
                    this.tableLayoutPanel.Controls.Add(newLabel, i, j);
                }
            }
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Size = new System.Drawing.Size(534, 511);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // timerForStepOfPlayer
            // 
            this.timerForStepOfPlayer.Interval = 750;
            this.timerForStepOfPlayer.Tick += new System.EventHandler(this.tickOfTheTimer);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GameForm";
            this.Text = "Find The Pair!";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.MaximizeBox = false;

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Timer timerForStepOfPlayer;
    }
}

