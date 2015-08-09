using System;
using System.Windows.Forms;
using System.Collections; 
using System.Drawing;

namespace ButtonTree1
{
	///<Authority>
	///this control is created by Syed Md. Abul Bashar Milton
	///Software Engineer 
	///<Version>
	///3.4.2.4
	///</Version> 
	
	///Last Modification Date : 04/09/2006(dd/MM/yyyy)
	///</Authority>
	/// <summary>
	/// This is Milton created Tree Node like Button Node which  contains MiButton
	/// </summary>
	public class ButtonNode:ArrayList
	{

		#region member variable
	
		public MiButton NodeButton;
		public Button IndicatorButton;
		public bool _Expanded=false;
		public ButtonNode _Parent=null;
		public Point StartPoint;
		public Point EndPoint;
		public Point _Location;
		private int _IndicatorButtonSeparator=15;
		private Image _IndicatorCloseImage;
		private Image _IndicatorOpenImage;
		public int Level;
		public ButtonTree  _RootPanel;
		public Int32 _NodePosition=-1;
		private int ExpandCount=0;
		public ButtonNode _RootNode;
		private int XLocation=0;
		private int YLocation=0;
		
		#endregion

		#region constructor

		public ButtonNode()
		{
			
			NodeButton=new MiButton(this);
			NodeButton.Visible=false;
			//NodeButton.Size = new Size(150,50);
			IndicatorButton=new Button();
			IndicatorButton.Visible=false;
			IndicatorButton.Padding = new Padding(0);
			IndicatorButton.Margin = new Padding(0);
			
			IndicatorButton.FlatAppearance.BorderSize = 0;
			IndicatorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			IndicatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
			IndicatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
			IndicatorButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			//IndicatorButton.BackColor=Color.White;
			IndicatorButton.TextAlign=ContentAlignment.MiddleLeft ;
			IndicatorButton.FlatStyle=FlatStyle.Flat ;
	

			IndicatorButton.Click+=new EventHandler(IndicatorButton_Click);
			NodeButton.Click+=new EventHandler(IndicatorButton_Click); 
//			//
			// TODO: Add constructor logic here
			//
		}
		#endregion
		#region public memeber function


		#region property

		public Int32 NodePosition
		{
			get
			{
				return _NodePosition;
			}
			set
			{
				_NodePosition=value;
			}

		}

		public ButtonNode RootNode
		{
			get
			{
				return _RootNode;
			}
			set
			{
				_RootNode=value;
			}
		}

		public int IndicatorButtonSeparator
		{
			get
			{
				return _IndicatorButtonSeparator;
			}
			set
			{
				_IndicatorButtonSeparator=value;
			}
		}
		public Size NodeButtonSize
		{
			get
			{
				return NodeButton.Size ;
			}
			
			
		}
	
		public Size IndicatorButtonSize
		{
			get
			{
				return IndicatorButton.Size ;
			}
			
		}

		public ButtonNode  Parent
		{
			get
			{
				return _Parent;
			}
			set
			{
				_Parent=value;

			}
		}

		public ButtonTree RootPanel
		{
			get
			{
				return _RootPanel;
			}
			set
			{
				_RootPanel=value;
			}
		}
		public bool Expanded
		{
			get
			{
				return _Expanded;
			}
			set
			{
				_Expanded=value;
			}
		}

		public Image IndicatorOffImage
		{
			get
			{
				return _IndicatorCloseImage  ;
			}
			set
			{
				_IndicatorCloseImage =value;
			}
		}

		public Image IndicatorOnImage
		{
			get
			{
				return _IndicatorOpenImage  ;
			}
			set
			{
				_IndicatorOpenImage =value;
			}
		}
		#endregion
		
		#region function
		
		public void SetLevel(ButtonNode btnNode)
		{
			
			foreach(ButtonNode btn in btnNode)
			{
				btn.Level=btnNode.Level+1;
				SetLevel(btn);
			}
		}

		private void SetIndicatorButtonYLocation()
		{
			IndicatorButton.Location=new Point(IndicatorButton.Location.X, this.NodeButton.Location.Y+this.NodeButtonSize.Height/2-IndicatorButtonSize.Height /2); 
		}
		
		
		public void ChangeVerticalLocation(ButtonNode btnNode,int spacing)
		{
			XLocation=btnNode.RootPanel.XRootLocation +btnNode.Level*(IndicatorButton.Width+this.RootPanel.NodeHorizontalSeparator);
			YLocation=YLocation+NodeButton.Height+RootPanel.NodeVerticalSeparator;
			btnNode.SetLocation(new Point(XLocation,YLocation));
			if(btnNode.Expanded==true)
			{
				foreach(ButtonNode btn in btnNode)
				{
					ChangeVerticalLocation(btn,spacing);
				}
			}
		}


		public void CollapseNode(ButtonNode btnNode)
		{
			foreach(ButtonNode btn in btnNode)
			{
				
				btn.NodeButton.Visible=false;
				btn.IndicatorButton.Visible=false;
				ExpandCount+=1;
				CollapseNode(btn);
				
			}
		}

		public void Collapse()
		{
			Expanded=false;
			this.IndicatorButton.Image=this.IndicatorOffImage;
			ExpandCount=0;
			YLocation=this.NodeButton.Location.Y;
            CollapseNode(this);
			int spacing =ExpandCount *(this.RootPanel.NodeVerticalSeparator+this.NodeButton.Size.Height);
			spacing=-spacing;
			ChangeNextNodeLocation(this,spacing);
			

		}


		public void ExpandNode(ButtonNode btnNode)
		{
			for(int i=0;i<btnNode.Count;i++)
			{
				ButtonNode btn=(ButtonNode)btnNode[i];
				btn.NodeButton.Visible=true;
				if(btn.Count>0)
					btn.IndicatorButton.Visible=true;
				XLocation=btnNode.RootPanel.XRootLocation+btn.Level*(IndicatorButton.Width+this.RootPanel.NodeHorizontalSeparator);
				YLocation=YLocation+NodeButton.Height+RootPanel.NodeVerticalSeparator;
				btn.SetLocation(new Point(XLocation,YLocation));
				if(btn.Expanded==true)
				ExpandNode(btn);
				ExpandCount+=1;
			}

		}
		public void Expand()
		{
			Expanded=true;
			this.IndicatorButton.Image=this.IndicatorOnImage;
			ExpandCount=0;
			YLocation=this.NodeButton.Location.Y;
			ExpandNode(this);

			int spacing =ExpandCount*(this.RootPanel.NodeVerticalSeparator+this.NodeButton.Size.Height);
	
			ChangeNextNodeLocation(this,spacing);
		}
		
		
		public void AddChild(ButtonNode btnNode)
		{
			btnNode.Parent=this;
			btnNode.NodePosition=this.Count;
			btnNode.Level=this.Level+1;
			SetLevel(btnNode);
			
			this.Add(btnNode);
		}

		
		public void SetLocation(Point sp)
		{

			this.IndicatorButton.Location=GetIndicatorButtonLocation(sp);
		this.NodeButton.Location=GetNodeButtonLocation(sp);
			

		}
		
		#endregion

		#endregion
		#region private member function
		private Point GetIndicatorButtonLocation(Point sp)
		{
			int X=sp.X;
			int Y=sp.Y +this.NodeButtonSize.Height/2-IndicatorButtonSize.Height /2;
			return new Point(X,Y);

		}
		private Point GetNodeButtonLocation(Point sp)
		{
			int X=sp.X+IndicatorButtonSize.Width+IndicatorButtonSeparator ;
			int Y=sp.Y;
			return new Point(X,Y);
		}

		


		public void ChangeNodeState()
		{
			if(this.Expanded==false)
			{	
								
				Expand();
			}
			else 
			{
				
							
				Collapse(); 

			}
		}
		private void IndicatorButton_Click(object sender, EventArgs e)
		{
			
			this.ChangeNodeState();

		}
		

		private void ChangeNextNodeLocation(ButtonNode btnNode,int spacing)
		{

			
			ButtonNode ParentNode=(ButtonNode)btnNode.Parent;
			if(ParentNode.Parent==null)
			{
				for(int i=btnNode.NodePosition+1;i<ParentNode.Count;i++)
				{
					ButtonNode btn=(ButtonNode)ParentNode[i];
						
					ChangeVerticalLocation(btn,spacing);
				}
				return;
			}

			else
			{
			
				for(int i=btnNode.NodePosition+1;i<ParentNode.Count;i++)
				{
					ButtonNode btn=(ButtonNode)ParentNode[i];
						
					ChangeVerticalLocation(btn,spacing);
				}
				ChangeNextNodeLocation(btnNode.Parent,spacing);
			}

		}
		#endregion
	}
}
