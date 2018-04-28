function TeacherViewModel() {
    var self = this;

    self.classes = ko.observable([]);
}

$(document).ready(function () { ko.applyBindings(new TeacherViewModel()); });