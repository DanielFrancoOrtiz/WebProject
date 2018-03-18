$(document).ready(function(){
    $('#tableGroups').DataTable({
        'aoColumnDefs' : [{'bSortable' : false, 'aTargets' : [2]}],
        'order' : [[0, 'asc']],
        'language' : {'url' : 'data_tables/DataTables-1.10.16/js/spanish.json'}
    }); 
});