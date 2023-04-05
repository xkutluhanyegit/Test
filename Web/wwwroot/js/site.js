$(document).ready(function(){
    $(function () {
        $("#ik-table").DataTable({
          "responsive": true, "lengthChange": false, "autoWidth": false,
          "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
        }).buttons().container().appendTo('#ik-table_wrapper .col-md-6:eq(0)');
    
      });

      $(function () {
        $("#departman-table").DataTable({
          "responsive": true, "lengthChange": false, "autoWidth": false,
          "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
        }).buttons().container().appendTo('#departman-table_wrapper .col-md-6:eq(0)');
    
      });

      

      $(function () {
        $('#shiftModal').on('shown.bs.modal', function (e) {
          $.fn.dataTable.tables({ visible: true, api: true }).columns.adjust();
      });

        $("#departman-shift-table").DataTable({
          
          "paging": false, 
          "scrollY": "400px",
          "scrollCollapse": true,
          "paging": false,
          "columnDefs": [ {
            "targets": 0,
            "orderable": false
            } ],
          "buttons": []
        }).buttons().container().appendTo('#example1-shift_wrapper .col-md-6:eq(0)');
      });

      $('#departman-shift-table tr').click(function (event) {
        if (event.target.type !== 'checkbox') {
          $(':checkbox', this).trigger('click');
        }
      });

      $('#radio-buttons input').on('change', function () {
        var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();
        $('#shiftID').attr('value', RadioBtnValue);
      });

      

      


});