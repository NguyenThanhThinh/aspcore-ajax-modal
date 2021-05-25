﻿namespace aspcore_ajax_modal.ViewModels
{

	public class Modal
	{
		public string ID { get; set; }
		public string AreaLabelID { get; set; }
		public ModalSize Size { get; set; }
		public string ModalSizeClass
		{
			get
			{
				switch (this.Size)
				{
					case ModalSize.Small:
						return "modal-sm";
					case ModalSize.Large:
						return "modal-lg";
					case ModalSize.Medium:
					default:
						return "";
				}
			}
		}
	}

}
