﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModalBootstrap.Models
{
    public class DeleteConfirmationViewModel
    {
        // Action to perform after user confirms "Delete".
        public string PostDeleteAction { get; set; }

        // [OPTIONAL] Controller to look for Post Delete action.
        // This controller has implementation of Post Delete action
        public string PostDeleteController { get; set; }

        // While executing POST Delete action, we need id of entity to delete.
        public int DeleteEntityId { get; set; }

        // Delete Confirmation dialog header text. For example
        // For text like "Delete Estimated Effort", Header Text is
        // "Estimated Effort"
        public string HeaderText { get; set; }
    }
}