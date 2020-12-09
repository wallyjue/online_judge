/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var ret1 = 0, ret2 =0;
    var cnt = 0, cnt2 =0;;

    for(cnt = 0; cnt < nums.length; cnt++)
    {
        for(cnt2 = cnt+1; cnt2 < nums.length; cnt2++)
        {
            if(nums[cnt] + nums[cnt2] == target)
            {
                ret1 = cnt;
                ret2 = cnt2;
                break;
            }
        }
    }
    var ret = [];
    ret.push(ret1);
    ret.push(ret2);
    return ret;
};

var problem = new twoSum([2, 7, 11, 15], 9);
problem.forEach( (x) => process.stdout.write(x.toString()));
