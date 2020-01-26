# ------------------------------------------------IMAGE PROCESSING PROJECT------------------------------------------------------------------ 

This project is using C# language to create a software able to modify an input image in a variation of ways. These include but not limited to
resize, crop, adjusting brightness and scaling.

Table of content

1. Confiuration
2. Installation
3. Operation
4. Manifest
5. Copyright and License
6. Contact Information

1. Configuration
	This project requires only a Windows personal computer to run the executable; otherwise, in order to examine the code properly it needs Visual Studio.  
2. Installation
	a) Turn on the personal computer.
	b) Navigate to the folder containing the project.
	c) To test the program, continue to navigate Bai1\bin\Debug and run Bai1.exe.
3. Operation	
	a) Once the program gets executed, a new window is opened, then click "Load Image" to open the image for modification.
	b) There are the following functions in this application:
		-	Scaling: select in the drop-down box the scaling color and click "Convert".
		-	Resize: choose either to resize the original or converted image, then the size and click "Apply".
		-	Contrast Adjustment: choose either the original or converted image, then the contrast value and click "Apply".
		- 	Noise Filter: choose either the original or converted image, then the filter size and click "Apply".
		-	Brightness Adjustment: choose either the original or converted image, then the brightness value and click "Apply".
		-	Gamma Adjustment: choose either the original or converted image, then the gamma value and click "Apply".
		-	Rotate: choose either the original or converted image, then the rotating angle and click "Apply".
		-	Crop: choose either the original or converted image, then a new window will show up allowing to select the retaining area and finally click 
			"Crop".
		-	For every succesive action, the program will ask whether to keep the previous modification or revert to prior version prior to applying the 
			new adjustment.
	c) Finally, images can be saved by clicking "Save" and selecting either "Original" or "Converted". The other image can be saved after the first save 
	is completed by repeating the procedure.
4. Manifest (list of files and short description of their roles)
	a) Form1, Form2 and Form3 and their associated files
		These files belong to another project.
	b) Form4 and its associated files
		These creates the main menu for the program and executes most of the modification.
	c) Form5 and its associated files
		These creates the windows asking whether to keep the previous modification before applying new adjustment.
	d) Form6 and its associated files
		Upon switching to modifying the original image or the other, these files creates a window to check if the current already adjusted image should 
		be saved or discarded.
	e) Form7 and its associated files
		These files will creates a new window to select the retaining area of the image when the cropping process is carried out.
	f) Program.cs
		This file initializes the program.
5. Copyright and License
	Window Operating System and Visual Studio are trademark of the Microsoft Corporation.
	Other trademarks and trade names are those of their respective owners.
	The person mentioned in the contact information content has the copyright and license for the code.		
6. Contact Information
	Tin Luu,
	Department of Information Technology
	Vaasa University of Applied Sciences
	Wolffintie 30, Vaasa, Finland
	Home: http://www.cc.puv.fi/~e1700674
	Email: e1700674(at)edu.vamk.fi
