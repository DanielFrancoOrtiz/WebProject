<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrmGrafica2.aspx.cs" Inherits="FrmGrafica2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
       <script src="Styles/js/highcharts.js"></script>
<script src="Styles/js/jquery.js"></script>
   
    <script src="Styles/js/exporting.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container" style="width: 100%;"></div>
    </form>
</body>

    <script>
      
       //$(function () {
       //    $('#container').highcharts({
       //        chart: {
       //            plotBackgroundColor: 'red',
       //            plotBorderWidth: null,
       //            plotShadow: false,
       //            type: 'pie'
       //        },
       //        title: {
       //            text: 'Browser market shares in January, 2018'
       //        },
       //        tooltip: {
       //            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
       //        },
       //        plotOptions: {
       //            pie: {
       //                allowPointSelect: true,
       //                cursor: 'pointer',
       //                dataLabels: {
       //                    enabled: true,
       //                    format: '<b>{point.name}</b>: {point.percentage:.1f} %',
       //                    style: {
       //                        color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
       //                    }
       //                }
       //            }
       //        },
       //        series: [{
       //            name: 'Brands',
       //            colorByPoint: true,
       //            data: [{
       //                name: 'Chrome',
       //                y: 61.41,
       //                sliced: true,
       //                selected: true
       //            }, {
       //                name: 'Internet Explorer',
       //                y: 11.84
       //            }, {
       //                name: 'Firefox',
       //                y: 10.85
       //            }, {
       //                name: 'Edge',
       //                y: 4.67
       //            }, {
       //                name: 'Safari',
       //                y: 4.18
       //            }, {
       //                name: 'Sogou Explorer',
       //                y: 1.64
       //            }, {
       //                name: 'Opera',
       //                y: 1.6
       //            }, {
       //                name: 'QQ',
       //                y: 1.2
       //            }, {
       //                name: 'Other',
       //                y: 2.61
       //            }]
       //        }]
       //    });
       //});
        //otra manera
       
         $(function () {
             $('#container').highcharts({
                 chart: {
                     plotBackgroundColor: null,
                     plotBorderWidth: 1,//null,
                     plotShadow: false
                 },
                 title: {
                     text: 'Visitas a mi web 2014'
                 },
                 subtitle:{
                     text: 'mipagina.com'
                 },
                 tooltip: {
                     pointFormat: '{series.name}: {point.y} (<b>{point.percentage:.1f}%</b>)'
                 },
                 plotOptions: {
                     pie: {
                         allowPointSelect: true,
                         cursor: 'pointer',
                         dataLabels: {
                             enabled: true,
                             format: '<b>{point.name}</b>: {point.y}',
                             style: {
                                 color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                             }
                         }
                     }
                 },
                 series: [{
                     type: 'pie',
                     name: 'Visitas',
                     data: [
                         ['Firefox', 326],
                         ['IE', 268],
                         {
                             name: 'Chrome',
                             y: 805,
                             sliced: true,
                             selected: true
                         },
                         ['Safari', 85],
                         ['Opera', 62],
                         ['Others', 7]
                     ]
                 }]
             });
         });

        //uso 
         //Highcharts.chart('container', {
         //    chart: {
         //        plotBackgroundColor: null,
         //        plotBorderWidth: null,
         //        plotShadow: false,
         //        type: 'pie'
         //    },
         //    title: {
         //        text: 'Browser market shares in January, 2018'
         //    },
         //    tooltip: {
         //        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
         //    },
         //    plotOptions: {
         //        pie: {
         //            allowPointSelect: true,
         //            cursor: 'pointer',
         //            dataLabels: {
         //                enabled: true,
         //                format: '<b>{point.name}</b>: {point.percentage:.1f} %',
         //                style: {
         //                    color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
         //                }
         //            }
         //        }
         //    },
         //    series: [{
         //        name: 'Brands',
         //        colorByPoint: true,
         //        data: [{
         //            name: 'Chrome',
         //            y: 61.41,
         //            sliced: true,
         //            selected: true
         //        }, {
         //            name: 'Internet Explorer',
         //            y: 11.84
         //        }, {
         //            name: 'Firefox',
         //            y: 10.85
         //        }, {
         //            name: 'Edge',
         //            y: 4.67
         //        }, {
         //            name: 'Safari',
         //            y: 4.18
         //        }, {
         //            name: 'Sogou Explorer',
         //            y: 1.64
         //        }, {
         //            name: 'Opera',
         //            y: 1.6
         //        }, {
         //            name: 'QQ',
         //            y: 1.2
         //        }, {
         //            name: 'Other',
         //            y: 2.61
         //        }]
         //    }]
         //});

    </script>
</html>
