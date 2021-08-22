set WORKSPACE=..\..
set GEN_CLIENT=%WORKSPACE%\Tools\Luban.Client\Luban.Client.exe
set CONF_ROOT=%WORKSPACE%\DesignerConfigs
set DEFINE_FILE=%CONF_ROOT%\Defines\__root__.xml

%GEN_CLIENT% -h %LUBAN_SERVER_IP% -j cfg --^
 -d %DEFINE_FILE%^
 --input_data_dir %CONF_ROOT%\Datas ^
 --output_code_dir Source/Cpp_Unreal/Private/Gen ^
 --output_data_dir ..\GenerateDatas\bin ^
 --gen_types code_cpp_bin,data_bin ^
 -s all ^
--export_test_data

pause