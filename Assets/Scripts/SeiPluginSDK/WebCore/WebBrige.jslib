var WebBrige = {
	OnLogin: function(data){
		var dataValue = UTF8ToString(data);

		window.dispatchReactUnityEvent(
			"OnLogin",
			dataValue
		);
	},

	OnExecute: function(data){
		var dataValue = UTF8ToString(data);
		window.dispatchReactUnityEvent(
				"OnExecute",
				dataValue
			);
	},

	OnQuery: function(data){
		var dataValue = UTF8ToString(data);
		window.dispatchReactUnityEvent(
				"OnQuery",
				dataValue
			);
	},
};
mergeInto(LibraryManager.library, WebBrige);