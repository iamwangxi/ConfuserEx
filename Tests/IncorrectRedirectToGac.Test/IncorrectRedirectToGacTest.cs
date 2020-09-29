using System.Threading.Tasks;
using Confuser.UnitTest;
using Xunit;
using Xunit.Abstractions;

namespace IncorrectRedirectToGac.Test {
	public class IncorrectRedirectToGacTest : TestBase {
		public IncorrectRedirectToGacTest(ITestOutputHelper outputHelper) : base(outputHelper) { }

		[Fact]
		[Trait("Category", "core")]
		[Trait("Issue", "https://github.com/mkaring/ConfuserEx/issues/144")]
		public async Task IncorrectRedirectToGac() =>
			await Run(
				new [] { "IncorrectRedirectToGac.exe", "Microsoft.Build.Framework.dll" }, new string[0], null
			);

		[Fact]
		[Trait("Category", "core")]
		[Trait("Issue", "https://github.com/mkaring/ConfuserEx/issues/144")]
		public async Task IncorrectExternalRedirectToGac() =>
			await Run(
				new [] { "IncorrectRedirectToGac.exe", "external:Microsoft.Build.Framework.dll" }, new string[0], null, outputDirSuffix: "_external"
			);
	}
}
