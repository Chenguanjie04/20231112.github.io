<form onsubmit="return baiduWithHttps(this)" action="http://www.baidu.com/baidu" target="_blank">
    <input name="tn" type="hidden" value="SE_zzsearchcode_shhzc78w">
    <a href=" " target="_blank">
        < img src="https://www.baidu.com/img/baidu_jgylogo3.gif" alt="Baidu" align="bottom" border="0">
    </a >
    <input type="text"  onfocus="checkHttps" name="word"  size="30">
    <input type="submit"value="百度搜索">
</form>
<script src="http://s1.bdstatic.com/r/www/cache/global/js/BaiduHttps_20150714_zhanzhang.js"></script>
<script>
    function checkHttps () {
        BaiduHttps.useHttps();    
    };
    function baiduWithHttps (formname) {
        var data = BaiduHttps.useHttps();
        if (data.s === 0) {
            return true;
        }
        else {
            formname.action = 'https://www.baidu.com/baidu' + '?ssl_s=1&ssl_c' + data.ssl_code;
            return true;
        }
    };
</script>