﻿using Sanford.Multimedia.Midi;

namespace SequencerDemo
{
    partial class Form1
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.positionHScrollBar = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMidiFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pianoControl1 = new Sanford.Multimedia.Midi.UI.PianoControl();
            this.sequence1 = new Sanford.Multimedia.Midi.Sequence();
            this.sequencer1 = new Sanford.Multimedia.Midi.Sequencer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(1, 44);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(54, 20);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(61, 44);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 20);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Stop";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // positionHScrollBar
            // 
            this.positionHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionHScrollBar.Location = new System.Drawing.Point(139, 44);
            this.positionHScrollBar.Name = "positionHScrollBar";
            this.positionHScrollBar.Size = new System.Drawing.Size(367, 20);
            this.positionHScrollBar.TabIndex = 3;
            this.positionHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.positionHScrollBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mIDIToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mIDIToolStripMenuItem
            // 
            this.mIDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputDeviceToolStripMenuItem});
            this.mIDIToolStripMenuItem.Name = "mIDIToolStripMenuItem";
            this.mIDIToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.mIDIToolStripMenuItem.Text = "&MIDI";
            // 
            // outputDeviceToolStripMenuItem
            // 
            this.outputDeviceToolStripMenuItem.Name = "outputDeviceToolStripMenuItem";
            this.outputDeviceToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.outputDeviceToolStripMenuItem.Text = "Output Device...";
            this.outputDeviceToolStripMenuItem.Click += new System.EventHandler(this.outputDeviceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openMidiFileDialog
            // 
            this.openMidiFileDialog.DefaultExt = "mid";
            this.openMidiFileDialog.Filter = "MIDI files|*.mid|All files|*.*";
            this.openMidiFileDialog.Title = "Open MIDI file";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pianoControl1
            // 
            this.pianoControl1.BackColor = System.Drawing.SystemColors.Control;
            this.pianoControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pianoControl1.HighNoteID = 109;
            this.pianoControl1.Location = new System.Drawing.Point(0, 254);
            this.pianoControl1.LowNoteID = 21;
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.NoteOnColor = System.Drawing.Color.SkyBlue;
            this.pianoControl1.Size = new System.Drawing.Size(515, 50);
            this.pianoControl1.TabIndex = 5;
            this.pianoControl1.Text = "pianoControl1";
            this.pianoControl1.PianoKeyDown += new System.EventHandler<Sanford.Multimedia.Midi.UI.PianoKeyEventArgs>(this.pianoControl1_PianoKeyDown);
            this.pianoControl1.PianoKeyUp += new System.EventHandler<Sanford.Multimedia.Midi.UI.PianoKeyEventArgs>(this.pianoControl1_PianoKeyUp);
            this.pianoControl1.Click += new System.EventHandler(this.pianoControl1_Click);
            // 
            // sequence1
            // 
            this.sequence1.Format = 1;
            // 
            // sequencer1
            // 
            this.sequencer1.Position = 0;
            this.sequencer1.Sequence = this.sequence1;
            this.sequencer1.PlayingCompleted += new System.EventHandler(this.HandlePlayingCompleted);
            this.sequencer1.ChannelMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.ChannelMessageEventArgs>(this.HandleChannelMessagePlayed);
            this.sequencer1.SysExMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.SysExMessageEventArgs>(this.HandleSysExMessagePlayed);
            this.sequencer1.Chased += new System.EventHandler<Sanford.Multimedia.Midi.ChasedEventArgs>(this.HandleChased);
            this.sequencer1.Stopped += new System.EventHandler<Sanford.Multimedia.Midi.StoppedEventArgs>(this.HandleStopped);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SequencerDemo.Properties.Resources._0ec9e4f07c8177f5c6fbeff174e8143f;
            this.ClientSize = new System.Drawing.Size(515, 326);
            this.Controls.Add(this.pianoControl1);
            this.Controls.Add(this.positionHScrollBar);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sequencer Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.HScrollBar positionHScrollBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openMidiFileDialog;
        private Sanford.Multimedia.Midi.UI.PianoControl pianoControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem mIDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDeviceToolStripMenuItem;
        private Sequence sequence1;
        private Sequencer sequencer1;
        private System.Windows.Forms.Timer timer1;
    }
}

