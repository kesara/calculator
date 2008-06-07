namespace Calculator.NET
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonPlusOrMinus = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonEaqual = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonMemoryRecall = new System.Windows.Forms.Button();
            this.buttonMemorySubtraction = new System.Windows.Forms.Button();
            this.buttonMemoryAddition = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.textBoxPad = new System.Windows.Forms.TextBox();
            this.buttonPadClear = new System.Windows.Forms.Button();
            this.buttonPadSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownNumbers = new System.Windows.Forms.ToolStripDropDownButton();
            this.operationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.memoryStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConversionStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonAllCancel = new System.Windows.Forms.Button();
            this.buttonSeperator = new System.Windows.Forms.Button();
            this.saveFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.ForeColor = System.Drawing.Color.Blue;
            this.buttonPeriod.Location = new System.Drawing.Point(124, 305);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(50, 30);
            this.buttonPeriod.TabIndex = 1;
            this.buttonPeriod.Tag = "period";
            this.buttonPeriod.Text = ".";
            this.buttonPeriod.UseVisualStyleBackColor = true;
            this.buttonPeriod.Click += new System.EventHandler(this.numberButtonClick);
            this.buttonPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button0
            // 
            this.button0.ForeColor = System.Drawing.Color.Blue;
            this.button0.Location = new System.Drawing.Point(12, 305);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(106, 30);
            this.button0.TabIndex = 2;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numberButtonClick);
            this.button0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 3;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numberButtonClick);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(68, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 30);
            this.button2.TabIndex = 4;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numberButtonClick);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(124, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 30);
            this.button3.TabIndex = 5;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numberButtonClick);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(124, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 30);
            this.button6.TabIndex = 8;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numberButtonClick);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(68, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 30);
            this.button5.TabIndex = 7;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numberButtonClick);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(12, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 30);
            this.button4.TabIndex = 6;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numberButtonClick);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonDivision
            // 
            this.buttonDivision.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDivision.Location = new System.Drawing.Point(124, 161);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(50, 30);
            this.buttonDivision.TabIndex = 14;
            this.buttonDivision.Tag = "÷";
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.operationClick);
            this.buttonDivision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonPlusOrMinus
            // 
            this.buttonPlusOrMinus.ForeColor = System.Drawing.Color.Blue;
            this.buttonPlusOrMinus.Location = new System.Drawing.Point(68, 161);
            this.buttonPlusOrMinus.Name = "buttonPlusOrMinus";
            this.buttonPlusOrMinus.Size = new System.Drawing.Size(50, 30);
            this.buttonPlusOrMinus.TabIndex = 13;
            this.buttonPlusOrMinus.Tag = "±";
            this.buttonPlusOrMinus.Text = "±";
            this.buttonPlusOrMinus.UseVisualStyleBackColor = true;
            this.buttonPlusOrMinus.Click += new System.EventHandler(this.numberButtonClick);
            this.buttonPlusOrMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.SeaGreen;
            this.button11.Location = new System.Drawing.Point(12, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 30);
            this.button11.TabIndex = 12;
            this.button11.Tag = "factorial";
            this.button11.Text = "x!";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operationClick);
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(124, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 30);
            this.button9.TabIndex = 11;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numberButtonClick);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(68, 197);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 30);
            this.button8.TabIndex = 10;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numberButtonClick);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(12, 197);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 30);
            this.button7.TabIndex = 9;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numberButtonClick);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonEaqual
            // 
            this.buttonEaqual.ForeColor = System.Drawing.Color.Maroon;
            this.buttonEaqual.Location = new System.Drawing.Point(180, 269);
            this.buttonEaqual.Name = "buttonEaqual";
            this.buttonEaqual.Size = new System.Drawing.Size(50, 66);
            this.buttonEaqual.TabIndex = 15;
            this.buttonEaqual.Tag = "=";
            this.buttonEaqual.Text = "=";
            this.buttonEaqual.UseVisualStyleBackColor = true;
            this.buttonEaqual.Click += new System.EventHandler(this.operationClick);
            this.buttonEaqual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonAddition
            // 
            this.buttonAddition.ForeColor = System.Drawing.Color.Maroon;
            this.buttonAddition.Location = new System.Drawing.Point(180, 233);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(50, 30);
            this.buttonAddition.TabIndex = 16;
            this.buttonAddition.Tag = "+";
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.operationClick);
            this.buttonAddition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSubtraction.Location = new System.Drawing.Point(180, 197);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(50, 30);
            this.buttonSubtraction.TabIndex = 17;
            this.buttonSubtraction.Tag = "-";
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.operationClick);
            this.buttonSubtraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMultiplication.Location = new System.Drawing.Point(180, 161);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(50, 30);
            this.buttonMultiplication.TabIndex = 18;
            this.buttonMultiplication.Tag = "×";
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.operationClick);
            this.buttonMultiplication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonSquareRoot.Location = new System.Drawing.Point(180, 125);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(50, 30);
            this.buttonSquareRoot.TabIndex = 22;
            this.buttonSquareRoot.Tag = "squareroot";
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.operationClick);
            this.buttonSquareRoot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonSquare
            // 
            this.buttonSquare.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonSquare.Location = new System.Drawing.Point(124, 125);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(50, 30);
            this.buttonSquare.TabIndex = 21;
            this.buttonSquare.Tag = "quare";
            this.buttonSquare.Text = "x²";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.operationClick);
            this.buttonSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonCube
            // 
            this.buttonCube.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonCube.Location = new System.Drawing.Point(68, 125);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(50, 30);
            this.buttonCube.TabIndex = 20;
            this.buttonCube.Tag = "cube";
            this.buttonCube.Text = "x³";
            this.buttonCube.UseVisualStyleBackColor = true;
            this.buttonCube.Click += new System.EventHandler(this.operationClick);
            this.buttonCube.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonPower
            // 
            this.buttonPower.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonPower.Location = new System.Drawing.Point(12, 125);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(50, 30);
            this.buttonPower.TabIndex = 19;
            this.buttonPower.Tag = "power";
            this.buttonPower.Text = "xⁿ";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.operationClick);
            this.buttonPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonMemoryRecall
            // 
            this.buttonMemoryRecall.Location = new System.Drawing.Point(180, 89);
            this.buttonMemoryRecall.Name = "buttonMemoryRecall";
            this.buttonMemoryRecall.Size = new System.Drawing.Size(50, 30);
            this.buttonMemoryRecall.TabIndex = 26;
            this.buttonMemoryRecall.Tag = "MR";
            this.buttonMemoryRecall.Text = "MR";
            this.buttonMemoryRecall.UseVisualStyleBackColor = true;
            this.buttonMemoryRecall.Click += new System.EventHandler(this.buttonMemoryRecall_Click);
            this.buttonMemoryRecall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonMemorySubtraction
            // 
            this.buttonMemorySubtraction.Location = new System.Drawing.Point(124, 89);
            this.buttonMemorySubtraction.Name = "buttonMemorySubtraction";
            this.buttonMemorySubtraction.Size = new System.Drawing.Size(50, 30);
            this.buttonMemorySubtraction.TabIndex = 25;
            this.buttonMemorySubtraction.Tag = "M-";
            this.buttonMemorySubtraction.Text = "M-";
            this.buttonMemorySubtraction.UseVisualStyleBackColor = true;
            this.buttonMemorySubtraction.Click += new System.EventHandler(this.buttonMemorySubtraction_Click);
            this.buttonMemorySubtraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonMemoryAddition
            // 
            this.buttonMemoryAddition.Location = new System.Drawing.Point(68, 89);
            this.buttonMemoryAddition.Name = "buttonMemoryAddition";
            this.buttonMemoryAddition.Size = new System.Drawing.Size(50, 30);
            this.buttonMemoryAddition.TabIndex = 24;
            this.buttonMemoryAddition.Tag = "M+";
            this.buttonMemoryAddition.Text = "M+";
            this.buttonMemoryAddition.UseVisualStyleBackColor = true;
            this.buttonMemoryAddition.Click += new System.EventHandler(this.buttonMemoryAddition_Click);
            this.buttonMemoryAddition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.Location = new System.Drawing.Point(12, 89);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(50, 30);
            this.buttonMemoryClear.TabIndex = 27;
            this.buttonMemoryClear.Tag = "MC";
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = true;
            this.buttonMemoryClear.Click += new System.EventHandler(this.buttonMemoryClear_Click);
            this.buttonMemoryClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // textBoxPad
            // 
            this.textBoxPad.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPad.Location = new System.Drawing.Point(236, 53);
            this.textBoxPad.Multiline = true;
            this.textBoxPad.Name = "textBoxPad";
            this.textBoxPad.ReadOnly = true;
            this.textBoxPad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPad.Size = new System.Drawing.Size(373, 253);
            this.textBoxPad.TabIndex = 28;
            this.textBoxPad.WordWrap = false;
            this.textBoxPad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonPadClear
            // 
            this.buttonPadClear.Location = new System.Drawing.Point(534, 312);
            this.buttonPadClear.Name = "buttonPadClear";
            this.buttonPadClear.Size = new System.Drawing.Size(75, 23);
            this.buttonPadClear.TabIndex = 29;
            this.buttonPadClear.Text = "&Clear";
            this.buttonPadClear.UseVisualStyleBackColor = true;
            this.buttonPadClear.Click += new System.EventHandler(this.clearPad);
            this.buttonPadClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonPadSave
            // 
            this.buttonPadSave.Location = new System.Drawing.Point(453, 312);
            this.buttonPadSave.Name = "buttonPadSave";
            this.buttonPadSave.Size = new System.Drawing.Size(75, 23);
            this.buttonPadSave.TabIndex = 30;
            this.buttonPadSave.Text = "&Save";
            this.buttonPadSave.UseVisualStyleBackColor = true;
            this.buttonPadSave.Click += new System.EventHandler(this.savePad);
            this.buttonPadSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(180, 53);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 30);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Tag = "C";
            this.buttonCancel.Text = "C";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // statusStripMain
            // 
            this.statusStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownNumbers,
            this.operationLabel,
            this.memoryStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 339);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(621, 22);
            this.statusStripMain.TabIndex = 32;
            this.statusStripMain.Text = "statusStrip1";
            this.statusStripMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // toolStripDropDownNumbers
            // 
            this.toolStripDropDownNumbers.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownNumbers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownNumbers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownNumbers.Image")));
            this.toolStripDropDownNumbers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownNumbers.Name = "toolStripDropDownNumbers";
            this.toolStripDropDownNumbers.Size = new System.Drawing.Size(81, 20);
            this.toolStripDropDownNumbers.Text = "Old Numbers";
            this.toolStripDropDownNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDropDownNumbers.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripDropDownNumbers.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownNumbers_DropDownItemClicked);
            // 
            // operationLabel
            // 
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(0, 17);
            this.operationLabel.ToolTipText = "Selected Operation";
            // 
            // memoryStatus
            // 
            this.memoryStatus.Name = "memoryStatus";
            this.memoryStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.unitConversionStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(621, 24);
            this.menuStripMain.TabIndex = 33;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.savePad);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.cutToolStripMenuItem.Text = "C&ut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.clear;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearPad);
            // 
            // unitConversionStripMenuItem
            // 
            this.unitConversionStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.volumeToolStripMenuItem,
            this.weightToolStripMenuItem,
            this.speedToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.informationStripMenuItem});
            this.unitConversionStripMenuItem.Name = "unitConversionStripMenuItem";
            this.unitConversionStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.unitConversionStripMenuItem.Text = "Unit Conversion";
            // 
            // lengthToolStripMenuItem
            // 
            this.lengthToolStripMenuItem.Name = "lengthToolStripMenuItem";
            this.lengthToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lengthToolStripMenuItem.Text = "Length";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.volumeToolStripMenuItem.Text = "Volume";
            // 
            // weightToolStripMenuItem
            // 
            this.weightToolStripMenuItem.Name = "weightToolStripMenuItem";
            this.weightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.weightToolStripMenuItem.Text = "Weight";
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // informationStripMenuItem
            // 
            this.informationStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storageToolStripMenuItem,
            this.speedToolStripMenuItem1});
            this.informationStripMenuItem.Name = "informationStripMenuItem";
            this.informationStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationStripMenuItem.Text = "Information";
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.storageToolStripMenuItem.Text = "Storage";
            // 
            // speedToolStripMenuItem1
            // 
            this.speedToolStripMenuItem1.Name = "speedToolStripMenuItem1";
            this.speedToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.speedToolStripMenuItem1.Text = "Data Transfer Rate";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::Calculator.NET.Properties.Resources.help;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.update;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "&Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Calculator.NET.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutToolStripMenuItem.Text = "&About Calculator.NET";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.ForeColor = System.Drawing.Color.Red;
            this.buttonBackspace.Location = new System.Drawing.Point(12, 53);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(106, 30);
            this.buttonBackspace.TabIndex = 34;
            this.buttonBackspace.Tag = "Backspace";
            this.buttonBackspace.Text = "Backspace";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.numberButtonClick);
            this.buttonBackspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 27);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(597, 20);
            this.textBoxDisplay.TabIndex = 35;
            this.textBoxDisplay.Text = "0";
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonAllCancel
            // 
            this.buttonAllCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonAllCancel.Location = new System.Drawing.Point(124, 53);
            this.buttonAllCancel.Name = "buttonAllCancel";
            this.buttonAllCancel.Size = new System.Drawing.Size(50, 30);
            this.buttonAllCancel.TabIndex = 36;
            this.buttonAllCancel.Tag = "AC";
            this.buttonAllCancel.Text = "AC";
            this.buttonAllCancel.UseVisualStyleBackColor = true;
            this.buttonAllCancel.Click += new System.EventHandler(this.buttonAllCancel_Click);
            this.buttonAllCancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // buttonSeperator
            // 
            this.buttonSeperator.Location = new System.Drawing.Point(372, 312);
            this.buttonSeperator.Name = "buttonSeperator";
            this.buttonSeperator.Size = new System.Drawing.Size(75, 23);
            this.buttonSeperator.TabIndex = 37;
            this.buttonSeperator.Text = "&Seperator";
            this.buttonSeperator.UseVisualStyleBackColor = true;
            this.buttonSeperator.Click += new System.EventHandler(this.buttonSeperator_Click);
            this.buttonSeperator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            // 
            // saveFileDialogBox
            // 
            this.saveFileDialogBox.Filter = "Text files|*.txt|All files|*.*";
            this.saveFileDialogBox.Title = "Save As";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 361);
            this.Controls.Add(this.buttonSeperator);
            this.Controls.Add(this.buttonAllCancel);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPadSave);
            this.Controls.Add(this.buttonPadClear);
            this.Controls.Add(this.textBoxPad);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.buttonMemoryRecall);
            this.Controls.Add(this.buttonMemorySubtraction);
            this.Controls.Add(this.buttonMemoryAddition);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonCube);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonEaqual);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonPlusOrMinus);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPeriod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator.NET";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPress);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPeriod;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonPlusOrMinus;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonEaqual;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonCube;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonMemoryRecall;
        private System.Windows.Forms.Button buttonMemorySubtraction;
        private System.Windows.Forms.Button buttonMemoryAddition;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.TextBox textBoxPad;
        private System.Windows.Forms.Button buttonPadClear;
        private System.Windows.Forms.Button buttonPadSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.ToolStripStatusLabel operationLabel;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownNumbers;
        private System.Windows.Forms.Button buttonAllCancel;
        private System.Windows.Forms.Button buttonSeperator;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBox;
        private System.Windows.Forms.ToolStripStatusLabel memoryStatus;
        private System.Windows.Forms.ToolStripMenuItem unitConversionStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem1;
    }
}

