// هو صنف يستخدم لمعالجة الطلبات مستخدم به نمط معين لبناء النسخة خطوة خطوة
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// اضافة السيرفس المطلوبة لعمل الكونترولر
builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
})
    .AddXmlDataContractSerializerFormatters()
    .AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// اضافة السيرفس الخاصة بروابط السواكر
builder.Services.AddEndpointsApiExplorer();
// اضافة السيرفس التي تحول الكونترولرس الى واجهة على سواكر
builder.Services.AddSwaggerGen();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// return request http to request https
app.UseHttpsRedirection();
// تتحقق من صلاحية الطلب القادم الى المشروع
app.UseAuthorization();
// تعمل على تحويل الطلب الى الكونترولر المطلوب ومن ثمن توجهه الى الدالة المطلوبة
app.MapControllers();

app.Run();
