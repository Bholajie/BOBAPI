﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bob.Model.DTO.CommentDTO
{
	public class CreateCommentRequestDTO
	{
		public Guid UserId { get; set; }
		[MaxLength(500)]
		public string CommentBody { get; set; }
		[JsonIgnore]
		public Guid PostId { get; set; }
		[JsonIgnore]
		public Guid OrganizationId { get; set; }
		public DateTime CreationDate { get; set; } = DateTime.UtcNow;
		public DateTime ModificaionDate { get; set; } = DateTime.UtcNow;
	}
}
