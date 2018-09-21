(function () {
    $(function () {

        var _categoryService = abp.services.app.category;
        var _$modal = $('#CategoryCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        $('#RefreshButton').click(function () {
            refreshCategoryList();
        });

        jQuery(document.body).on('click', '.delete-category', function (e) {
            var categoryId = $(this).attr("data-category-id");
            var categoryName = $(this).attr("data-category-name");

            deleteCategory(categoryId, categoryName);
        });

        jQuery(document.body).on('click', '.edit-category', function (e) {
            var categoryId = $(this).attr("data-category-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Categorys/EditCategoryModal?categoryId=' + categoryId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#CategoryEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var category = { "category": _$form.serializeFormToObject() }; //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$modal);
            _categoryService.createOrUpdate(category).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new category!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshCategoryList() {
            location.reload(true); //reload page to see new category!
        }

        function deleteCategory(categoryId, categoryName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Hasin'), categoryName),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _categoryService.delete({
                            id: categoryId
                        }).done(function () {
                            refreshCategoryList();
                        });
                    }
                }
            );
        }

        var options = {
            "ajax": function (data, callback, settings) {
                abp.services.app.category.getPaged({
                    "name": $("#txtCategoryName").val(),
                    "filter": "",
                    "sorting": "",
                    "maxResultCount": data.length,
                    "skipCount": data.start
                }).done(function (json) {
                    var data = {
                        "draw": settings.draw,
                        "data": json.items,
                        "recordsTotal": json.totalCount,
                        "recordsFiltered": json.totalCount
                    };
                    callback(data);
                });
            }, "columns": [
                { "data": "name" },
                { "data": "creationTimeFormat" },
                {
                    data: null, render: function (data, type, row) {
                        var temp = "<a class=\"waves-effect edit-category\" data-category-id=\"" + data.id + "\" data-toggle=\"modal\" data-target=\"#CategoryEditModal\"><i class=\"material-icons\">edit</i></a>&nbsp;&nbsp;<a class=\"waves-effect delete-category\" data-category-id=\"" + data.id + "\" data-category-name=\"" + data.name + "\"><i class=\"material-icons\">delete_sweep</i></a>"
                        return temp;
                    }
                }
            ]
        }

        var defaults = {
            "searching": false,
            "processing": true,
            "serverSide": true,
            "ordering": false,
            "destroy": true,
            "bLengthChange": false,
            "iDisplayLength":8,
            "language": {
                url: '//cdn.datatables.net/plug-ins/1.10.16/i18n/Chinese.json'
            }
        }
        var settings = $.extend({}, defaults, options);

        var table = $("#tbMain").DataTable(settings);

        jQuery(document.body).on('click', '#btnQuery', function (e) {
            table.draw(false);
        });
    });
})();