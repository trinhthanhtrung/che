using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EveryoneCouldBeCHE
{
    public partial class MainForm : Form
    {
    	private System.Drawing.Bitmap m_Bitmap;
    	
		private bool File_Load()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = "c:\\" ;
			openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp;*.jpg)|*.bmp;*.jpg";
			openFileDialog.FilterIndex = 3 ;
			openFileDialog.RestoreDirectory = true ;

			if(DialogResult.OK == openFileDialog.ShowDialog())
			{
				m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
				this.Invalidate();
				return true;
			}
			return false;
		}

		private string File_Save()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.InitialDirectory = "c:\\" ;
			saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg" ;
			saveFileDialog.FilterIndex = 1 ;
			saveFileDialog.RestoreDirectory = true ;

			if(DialogResult.OK == saveFileDialog.ShowDialog())
			{
				m_Bitmap.Save(saveFileDialog.FileName);
			}
			else
				return "";
			
			return saveFileDialog.FileName;
		}
    	
		private bool Cheguevarize(int threshold)
        {
			
			if (BitmapFilter.Cheguevarize(m_Bitmap, threshold))
			{
                this.Invalidate();
                return true;
			}
            return false;
        }
		
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        // Cheguevarize
        void BtnOpenClick(object sender, EventArgs e)
        {
        	// Open the open file dialog
        	if (File_Load())
        	{
	        	// Cheguevarize the image
	        	bool rsp = Cheguevarize(hThreshold.Value);
	        	// Display instruction
	        	if (rsp)
	        	{
	        		MessageBox.Show("Now find a place to save your Che image.", "Save your Che image", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        		// Open the save file dialog
	        		string savedImagePath = File_Save();
	        		if (savedImagePath != "")
	        		{
		        		DialogResult viewCheImg = MessageBox.Show("Your Che image has been created. Do you wanna view it now?", "View your Che image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		        		
		        		if (viewCheImg == DialogResult.Yes)
		        			System.Diagnostics.Process.Start(savedImagePath);
		        	}	
	        	}
	        	else
	        		MessageBox.Show("You failed to be Che. May be because you are greater than him?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        	}
        }
    }
}
