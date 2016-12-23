/*
    JSModel
    Copyright (c) 2014 Chad Kuehn (chadkuehn.com)
    Licensed under the MIT license (https://github.com/chadkuehn/JSModel/blob/master/LICENSE.txt)
    Version: 1.0.6
*/

function JSModel() {
    
	//PRIVATE VARIABLES
	var url = '';
	var mod;
	
	
	// CONSTRUCTOR
    // arg1: model object (REQUIRED)
    // arg2: url for a ajax requests (OPTIONAL)
    if (!(function (args) {
        var result = false;
        if (args.length > 0) {
            if (typeof args[0] === "object") {
				mod = args[0];
				if (args.length > 1) {
					if (typeof args[1] === "string") {
					   url = args[1];
					   result = true;
					}
				} else {
				   result = true;
				}
            }
        }
        return result;
    } (arguments))) {
        return;
    }
	
	
	//PUBLIC METHODS
    this.refresh = refresh;
	this.prop = prop;
	
	
	
	//addressing a shortcoming of Html.Raw/Json.Encode
	 for (var prop in mod) {
		var val = mod[prop];
		if (typeof val == "string") {
			if (val.indexOf('/Date(') == 0) {
				var dt = new Date(parseInt(val.substr(6)));
				mod[prop] = dt;
			}
		}
    }
	
	
	
	
    /// <summary>
    ///    This returns the value of a property in the model.
	///    It does not re-check the DOM.  Use refresh() instead for an update on all properties including dependants.
    /// </summary>
	/// <param name="propname">The property name you seek</param>
    /// <returns>The property value</returns>	
	function prop(propname) {
		var result;
		if(propname in mod) {
			result = mod[propname];
		}
		return result;
	}


	
	
    /// <summary>
    ///    Call this method to refresh the model with the current state of the DOM
	///    A refresh can be performed any time after a page load.
    /// </summary>
    /// <returns>The current model object</returns>
	function refresh() {
		var obj = {};

		for (var key in mod) {
			var fld = $("[name='" + key + "']");


			var type = "";
			if (fld.is("input")) {
				type = fld.attr("type");
			} else if (fld.is("select")) {
				type = "select";
			} else if (fld.is("textarea")) {
				type = "textarea";
			}

			switch (type) {
				case "select":
				case "textarea":
				case "text":
				case "password":
				case "hidden":
				case undefined:
					if ($.isArray(mod[key])) {
						mod[key] = fld.map(function () {
							return this.value;
						}).get();
					} else {
						mod[key] = fld.val();
					}
					break;
				case "radio":
					mod[key] = fld.closest(":checked").val();
					break;
				case "checkbox":
					mod[key] = fld.closest(":checked").map(function () {
						return this.value;
					}).get();
					break;
			}

			var chks = [];

			$("[name ^= '" + key + "['][name *= ']'").each(function () {

				var fld = $(this);
				var name = fld.attr("name");
				var val = fld.val();

				if (fld.is("input")) {
					if (fld.attr("type") == "checkbox") {
						if (fld.is(":checked")) {
							chks.push(name);
						}
						return;
					}
				}
				if (chks.indexOf(name) > -1) {
					val = "true";
				}

				if (!isNaN(val)) {
					if (val.indexOf(".") > -1) {
						val = parseInt(val, 10);
					} else {
						val = parseFloat(val, 10);
					}
				} else if ((val == "true") || (val == "false")) {
					val = (val == "true" ? true : false);
				}
				var regexp = /\[(\d)\]/g;
				var match = regexp.exec(name);
				var idxs = [];
				while (match != null) {
					idxs.push(parseInt(match[1], 10));
					match = regexp.exec(name);
				}

				var regexp = /\.([^/[]+)/g;
				var match = regexp.exec(name);
				var props = [];
				while (match != null) {
					props.push(match[1]);
					match = regexp.exec(name);
				}
				if (idxs.length != props.length) {
					return;
				}
				props.unshift(key);
				var last = obj;

				for (var propLoop = 0; propLoop < props.length; propLoop++) {
					var prop = props[propLoop];
					var lastIteration = false;
					if (propLoop == props.length - 1) {
						lastIteration = true;
					}
					if (lastIteration) {
						last[prop] = val;
						return;
					}
					var idx = -1;
					if (!lastIteration) {
						idx = idxs[0];
						idxs.shift();
					}
					if (!(prop in last)) {
						last[prop] = [];
					}
					last = last[prop];


					for (var x = last.length; x < (idx + 1); x++) {
						last.push({});
					}
					last = last[idx];
				}
			});
		}

		for (var key in obj) {
			mod[key] = obj[key];
		}

		if (url != "") {
			var newmodel = $.ajax({
				url: url,
				type: "POST",
				async: false, // synchronous
				contentType: "application/json;charset=utf-8;",
				dataType: "json",
				data: JSON.stringify(mod)
			}).responseText;

			mod = JSON.parse(newmodel);
		}
		return mod;
	}
 }